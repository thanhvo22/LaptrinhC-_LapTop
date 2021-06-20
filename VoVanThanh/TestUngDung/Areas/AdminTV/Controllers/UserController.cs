
using ModelEF;
using ModelEF.DAO;
using ModelEF.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Areas.AdminTV.Models;

namespace TestUngDung.Areas.AdminTV.Controllers
{
    public class UserController : Controller
    {
        // GET: AdminTV/User
        private VoVanThanhContext db = new VoVanThanhContext();
        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var user = new UserDAO();
            var model = user.ListAll();
            return View(model.ToPagedList(page, pagesize));
        }
        //timkiem, phan trang
        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var user = new UserDAO();
            var model = user.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model.ToPagedList(page, pagesize));
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(UserAccount model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                if (dao.Find(model.Username)!= null)
                {
                    return RedirectToAction("create", "User");
                }
                var pass = common.EncryptMD5(model.Password);
                model.Password = pass;
                string result = dao.Insert(model);
                if (!string.IsNullOrEmpty( result))
                {
                    //ModelState.AddModelError("", "Dang nhap thanh cong");
              
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "tao nguoi dung that bai");
                    //Session.Add(Constans.USER_SESSION, login.password);
                }

            }
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Category category = db.Category.Find(id);
            db.Category.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpDelete]
        public ActionResult Delete(string username)
        {
            var dao= new UserDAO().Delete(username);
            return RedirectToAction("Index");
        }
    }
}