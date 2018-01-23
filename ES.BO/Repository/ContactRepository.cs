using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {
            db.Contact.Remove(db.Contact.Find(itemId));
            db.SaveChanges();
        }

        public void Insert(Contact item)
        {
            db.Contact.Add(item);
            db.SaveChanges();
        }

        public List<Contact> SelectAll()
        {
            return db.Contact.ToList();
        }

        public Contact SelectById(int itemId)
        {
            return db.Contact.Find(itemId);
        }

        public void Update(Contact item)
        {
            Contact updated = db.Contact.Find(item.ContactId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
