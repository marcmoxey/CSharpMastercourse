using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerLibrary.Models;

namespace TaskManagerLibrary.Interfaces
{
    public interface ITaskManager
    {
        void AddTask(string taskName, DateTime dueDate, TaskState status);
        void ViewTasks(TaskState? status = null);
        void DeleteTask(int taskId);
        void GetSummary();
    }
}
