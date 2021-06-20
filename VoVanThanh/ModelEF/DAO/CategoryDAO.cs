using ModelEF.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class CategoryDAO
    {
        VoVanThanhContext db = null;
        public CategoryDAO()
        {
            db = new VoVanThanhContext();
        }
        public long Insert(Category entity)
        {
            db.Category.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public IEnumerable<Category> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<Category> model = db.Category;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString));
            }
            return model.OrderBy(x => x.ID).ToPagedList(page, pageSize);
        }
        public Category GetByID(string Name)
        {
            return db.Category.SingleOrDefault(x => x.Name == Name);
        }
        public Category ViewDetail(int id)
        {
            return db.Category.Find(id);
        }
        public bool Delete(int id)
        {
            try
            {
                var name = db.Category.Find(id);
                db.Category.Remove(name);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //get category
        public List<Category> ListAll()
        {
            return db.Category.ToList();
        }
        //public void SetViewBag(long? selectedId)
        //{
        //    var dao = new CategoryDAO();
        //    ViewBag.

        //}
    }
}
