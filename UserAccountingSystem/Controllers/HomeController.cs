using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAccountingSystem.DAL;

namespace UserAccountingSystem.Controllers
{
    public class HomeController : Controller
    {
        private UserAccountingContext db = new UserAccountingContext();
        public ActionResult UserList()
        {
            var users = db.Users.ToList();
            return View(users);
        }

    }
}