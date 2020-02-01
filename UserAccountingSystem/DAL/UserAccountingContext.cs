using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserAccountingSystem.Models;

namespace UserAccountingSystem.DAL
{
    public class UserAccountingContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserAccountingContext() : base("UserAccountingContext")
        {

        }
    }
}