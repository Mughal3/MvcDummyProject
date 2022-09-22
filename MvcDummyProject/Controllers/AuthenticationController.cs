using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDummyProject.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult SignUP()
        {
            return View();
        }
        public ActionResult SignIN()
        {
            return View();
        }
    }
}