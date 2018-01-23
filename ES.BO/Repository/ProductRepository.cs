using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {

            db.Product.Remove(db.Product.Find(itemId));
            db.SaveChanges();
        }

        public void Insert(Product item)
        {

            db.Product.Add(item);
            db.SaveChanges();
        }

        public List<Product> SelectAll()
        {
            return db.Product.ToList();
        }

        public Product SelectById(int itemId)
        {
            return db.Product.Find(itemId);
        }

        public void Update(Product item)
        {
            Product updated = db.Product.Find(item.ProductID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
