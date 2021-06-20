using TestUngDung.Areas.AdminTV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung;
using ModelEF;

namespace TestUngDung.Areas.AdminTV.Controllers
{
    public class HomeController : Controller
    {

        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session[Constans.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}