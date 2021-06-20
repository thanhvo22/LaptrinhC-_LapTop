using ModelEF.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    
    public class ProductDAO
    {
        private VoVanThanhContext db;
        public ProductDAO()
        {
            db = new VoVanThanhContext();

        }

        //sapxep
        public List<Product> ListAll()
        {
            return db.Product.OrderBy(x=>x.Quantity).ThenByDescending(x=>x.UnitCost).ToList();
        }
        public IEnumerable<Product> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<Product> model = db.Product;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.Name.Contains(keysearch));
            }
            return model.OrderBy(x => x.Name).ToPagedList(page, pagesize);
        }

        public string Insert(Product entityProduct)
        {
            db.Product.Add(entityProduct);
            db.SaveChanges();
            return entityProduct.Name;
        }

        public Product Find(string name)
        {
            return db.Product.Find(name);
        }

        public bool Delete(string name)
        {
            try
            {
                var user = db.Product.Find(name);
                db.Product.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
