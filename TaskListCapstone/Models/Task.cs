using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListCapstone.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool Complete { get; set; }
    }

    public class DbTaskContext : DbContext
    {
        //DbSet<Task> Tasks { get; set; }

       public System.Data.Entity.DbSet<TaskListCapstone.Models.Task> Tasks { get; set; }
    }
}