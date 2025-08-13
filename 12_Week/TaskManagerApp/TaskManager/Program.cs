using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerLibrary.Models;
using TaskManagerLibrary.Interfaces;
using TaskManagerLibrary;

namespace TaskManagerApp
{
    class Program
    {
        static ITaskManager taskManager = new TaskManager();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Get Summary");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTaskUI();
                        break;
                    case "2":
                        ViewTasksUI();
                        break;
                    case "3":
                        DeleteTaskUI();
                        break;
                    case "4":
                        taskManager.GetSummary();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        static void AddTaskUI()
        {
            Console.Write("Enter task name: ");
            string taskName = Console.ReadLine();

            Console.Write("Enter due date (yyyy-MM-dd): ");
            DateTime dueDate;
            while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out dueDate))
            {
                Console.Write("Invalid date format. Please try again (yyyy-MM-dd): ");
            }

            Console.Write("Enter status (Pending/Completed): ");
            string statusInput = Console.ReadLine().ToLower();
            TaskState status = statusInput == "completed" ? TaskState.Completed : TaskState.Pending;

            taskManager.AddTask(taskName, dueDate, status);
        }

        static void ViewTasksUI()
        {
            Console.WriteLine("1. View all tasks");
            Console.WriteLine("2. View pending tasks");
            Console.WriteLine("3. View completed tasks");
            Console.Write("Enter choice: ");
            string filterChoice = Console.ReadLine();

            TaskState? filterStatus = null;
            if (filterChoice == "2")
            {
                filterStatus = TaskState.Pending;
            }
            else if (filterChoice == "3")
            {
                filterStatus = TaskState.Completed;
            }

            taskManager.ViewTasks(filterStatus);
        }

        static void DeleteTaskUI()
        {
            Console.Write("Enter task ID to delete: ");
            int taskId;
            while (!int.TryParse(Console.ReadLine(), out taskId))
            {
                Console.Write("Invalid ID. Please enter a valid task ID: ");
            }

            taskManager.DeleteTask(taskId);
        }
    }
}
