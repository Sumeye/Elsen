using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class ColorRepository : IRepository<ProductColor>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {
            db.ProductColor.Remove(db.ProductColor.Find(itemId));
            db.SaveChanges();
        }

        public void Insert(ProductColor item)
        {
            db.ProductColor.Add(item);
            db.SaveChanges();
        }

        public List<ProductColor> SelectAll()
        {
            return db.ProductColor.ToList();
        }

        public ProductColor SelectById(int itemId)
        {
            return db.ProductColor.Find(itemId);
        }

        public void Update(ProductColor item)
        {
            ProductColor updated = db.ProductColor.Find(item.ColorId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
