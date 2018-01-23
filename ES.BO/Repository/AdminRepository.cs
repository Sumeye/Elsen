using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class AdminRepository : IRepository<Admin>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {
            db.Admin.Remove(db.Admin.Find(itemId));
            db.SaveChanges();
        }

        public void Insert(Admin item)
        {
            db.Admin.Add(item);
            db.SaveChanges();
        }

        public List<Admin> SelectAll()
        {
            return db.Admin.ToList();
        }

        public Admin SelectById(int itemId)
        {
            return db.Admin.Find(itemId);
        }

        public void Update(Admin item)
        {
            Admin updated = db.Admin.Find(item.AdminID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
