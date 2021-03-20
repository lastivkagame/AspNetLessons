using FiltersMVC.Filters;
using FiltersMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FiltersMVC.Controllers
{
    //Фільтри
    //  - Авторизації - перевірка на користувача
    //  - Аутентифікації - перевірка на права
    //  - Фільтри виключення
    //  - Action Filters
    //  - Resalt Filters

    [HandleError(View = "CustomError")]
    public class HomeController : Controller
    {
        private readonly Random random = new Random();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");

            }

            if (user.Password == "1" && user.Login == "admin" || user.Login == "user")
            {
                FormsAuthentication.SetAuthCookie(user.Login, true);
                return RedirectToAction("Index");
            }

            return new HttpUnauthorizedResult();

        }

        [Authorize]
        public string TestFilter()
        {
            return $"Hello {User.Identity.Name}!";
        }

        [HttpPost]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public string GenerateException()
        {
            var number = new Random().Next(6);

            if (number > 3)
            {
                throw new ArgumentException($"The number {number} should be less 3");
            }
            else
            {
                return "Everything is OK!";
            }
        }

        [CustomActionFilter]
        public string TestAction()
        {
            Thread.Sleep(4000);
            return "Work in Action!";
        }

        [HttpPost]
        public ActionResult GetInfo()
        {
            var states = new[] { "Pending", "New", "In Progress", "Closed", "Canceled" };
            var state = states[random.Next(states.Length)];
            return Json(new { result = state }, JsonRequestBehavior.AllowGet);
        }
    }
}