using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login ()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Login (string user, string pass)
        {
            if("admin".Equals(user) && "123".Equals(pass))
            {

            }
            return View();
        }
      
    }
}
