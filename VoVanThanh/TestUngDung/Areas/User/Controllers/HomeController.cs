using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        // GET: User/Home
        public ActionResult Index()
        {
            var id = new ProductDAO();
            var model = id.ListAll();
            return View(model);
        }
        //public ActionResult Index(int page = 1, int pagesize = 5)
        //{
        //    var id = new ProductDAO();
        //    var model = id.ListAll();
        //    return View(model.ToPagedList(page, pagesize));
        //}
    }
}