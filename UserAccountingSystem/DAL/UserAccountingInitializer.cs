using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserAccountingSystem.Models;

namespace UserAccountingSystem.DAL
{
    public class UserAccountingInitializer : DropCreateDatabaseIfModelChanges<UserAccountingContext>
    {
        protected override void Seed(UserAccountingContext context)
        {
            var Users = new List<User>()
            {
                new User() {FirstName = "Андрей", LastName="Ханин"},
                new User() {FirstName = "Василий", LastName="Иванов"},
                new User() {FirstName = "Петр", LastName="Петров", MiddleName="Петрович" },
            };

            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}