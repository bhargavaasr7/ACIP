using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACIP.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult LoginWithOutCredentials()
        {
            return View();
        }
    }
}