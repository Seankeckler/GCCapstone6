using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListCapstone.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class DbUserContext : DbContext
    {
        //DbSet<User> Users { get; set; }

       public System.Data.Entity.DbSet<TaskListCapstone.Models.User> Users { get; set; }
    }
}