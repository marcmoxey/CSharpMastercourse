using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerLibrary.Models
{
    public class TaskModel
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public TaskState Status { get; set; }

        public TaskModel(int id, string taskName, DateTime dueDate, TaskState status)
        {
            ID = id;
            TaskName = taskName;
            DueDate = dueDate;
            Status = status;
        }
    }
}

