using ModelEF;
using ModelEF.DAO;
using ModelEF.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.AdminTV.Controllers
{
    public class ProductController : Controller
    {
        // GET: AdminTV/Product
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private VoVanThanhContext db = new VoVanThanhContext();
        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var product = new ProductDAO();
            var model = product.ListAll();
            return View(model.ToPagedList(page, pagesize));
        }

        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        //dropdowlist
        public void SetViewBag(long? selectedID = null)
        {
            var dao = new CategoryDAO();
            ViewBag.ProductType = new SelectList(dao.ListAll(), "ID", "Name", selectedID);
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name,UnitCost,Quantity,Description,Status,ProductType")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //timkiem, phan trang
        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var product = new ProductDAO();
            var model = product.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model.ToPagedList(page, pagesize));
        }



        [HttpDelete]
        public ActionResult Delete(string name)
        {
            var dao = new ProductDAO().Delete(name);
            return RedirectToAction("Index");
        }

        //get productDetail/productID
        public ActionResult ProductDetail (long id)
        {
            Product product = db.Product.Where(x => x.ID == id).SingleOrDefault();
            return View(product);
        }
    }
}