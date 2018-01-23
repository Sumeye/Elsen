using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class SizeRepository : IRepository<ProductSize>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {
            db.ProductSize.Remove(db.ProductSize.Find(itemId));
            db.SaveChanges();
        }

        public void Insert(ProductSize item)
        {
            db.ProductSize.Add(item);
            db.SaveChanges();
        }

        public List<ProductSize> SelectAll()
        {
            return db.ProductSize.ToList();
        }

        public ProductSize SelectById(int itemId)
        {
            return db.ProductSize.Find(itemId);
        }

        public void Update(ProductSize item)
        {
            ProductSize updated = db.ProductSize.Find(item.SizeID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
