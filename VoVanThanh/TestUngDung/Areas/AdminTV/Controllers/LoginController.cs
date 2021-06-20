using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.DAO;
using TestUngDung.Areas.AdminTV.Models;
using System.Reflection.Metadata;
using ModelEF;

namespace TestUngDung.Areas.AdminTV.Controllers
{
    public class LoginController : Controller
    {
        

        // GET: AdminTV/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
               
                var result = dao.login(login.Username, common.EncryptMD5(login.Password));
                if (result == 1)
                {
                    //ModelState.AddModelError("", "Dang nhap thanh cong");
                    Session.Add(Constans.USER_SESSION,login.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Dang nhap that bai");
                    //Session.Add(Constans.USER_SESSION, login.password);
                }

            }
            return View("Index");
        }

    }
}