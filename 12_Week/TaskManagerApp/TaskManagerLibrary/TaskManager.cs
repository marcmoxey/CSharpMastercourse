using System;
using System.Collections.Generic;
using System.Linq;
using TaskManagerLibrary.Models;
using TaskManagerLibrary.Interfaces;

namespace TaskManagerLibrary
{
    public class TaskManager : ITaskManager
    {
        private List<TaskModel> tasks = new List<TaskModel>();
        private static int nextTaskId = 1; // Static variable to generate unique IDs

       
        public void AddTask(string taskName, DateTime dueDate, TaskState status)
        {
            int taskId = nextTaskId++; // Get the current ID and increment it for the next task
            tasks.Add(new TaskModel(taskId, taskName, dueDate, status));
            Console.WriteLine("Task added successfully!\n");
        }

        public void ViewTasks(TaskState? status = null)
        {
            var filteredTasks = tasks.AsEnumerable();

            if (status.HasValue)
            {
                filteredTasks = filteredTasks.Where(t => t.Status == status.Value);
            }

            if (!filteredTasks.Any())
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                foreach (var task in filteredTasks)
                {
                    Console.WriteLine($"ID: {task.ID} - Task: {task.TaskName}, Due Date: {task.DueDate.ToShortDateString()}, Status: {task.Status}");
                }
            }
        }

        public void DeleteTask(int taskId)
        {
            var task = tasks.FirstOrDefault(t => t.ID == taskId);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Task deleted successfully.\n");
            }
            else
            {
                Console.WriteLine("Task not found.\n");
            }
        }

        public void GetSummary()
        {
            int pendingTasks = tasks.Count(t => t.Status == TaskState.Pending);
            int completedTasks = tasks.Count(t => t.Status == TaskState.Completed);

            Console.WriteLine($"Total Tasks: {tasks.Count}");
            Console.WriteLine($"Completed Tasks: {completedTasks}");
            Console.WriteLine($"Pending Tasks: {pendingTasks}\n");
        }
    }
}

