using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserAccountingSystem.DAL;
using UserAccountingSystem.Models;

namespace UserAccountingSystem.Controllers
{
    public class HomeController : Controller
    {
        private UserAccountingContext db = new UserAccountingContext();
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}