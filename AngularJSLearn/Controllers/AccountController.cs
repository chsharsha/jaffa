using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSLearn.Models;


namespace AngularJSLearn.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       

        [AllowAnonymous]
        //
        // GET: /Account/
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            ViewBag.Yes = "Hit";
            return View();
        }
	}
}