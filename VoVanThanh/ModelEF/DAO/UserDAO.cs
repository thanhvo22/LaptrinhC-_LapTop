using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.EF;
using PagedList;

namespace ModelEF.DAO
{
    public class UserDAO
    {
        private VoVanThanhContext db;

        public UserDAO()
        {
            db = new VoVanThanhContext();

        }
        public int login(string user, string pass)
        {
            var result = db.UserAccount.SingleOrDefault(x=>x.Username.Contains(user)&&x.Password.Contains(pass));
            if(result == null){
                return 0;
            }
            else
                return 1;

        }
        public List<UserAccount> ListAll()
        {
            return db.UserAccount.ToList();
        }
        
        
        public IEnumerable<UserAccount> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<UserAccount> model = db.UserAccount;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model =model.Where(x => x.Username.Contains(keysearch));
            }
            return model.OrderBy(x=>x.Username).ToPagedList(page, pagesize);
        }

        public string Insert(UserAccount entityUser)
        {
            db.UserAccount.Add(entityUser);
            db.SaveChanges();
            return entityUser.Username;
        }
        
        public UserAccount Find(string username)
        {
            return db.UserAccount.Find(username);
        }

        public bool Delete(string username)
        {
            try
            {
                var user = db.UserAccount.Find(username);
                db.UserAccount.Remove(user);
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
