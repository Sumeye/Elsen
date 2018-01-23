using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class BrandRepository : IRepository<ProductBrand>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {
            db.ProductBrand.Remove(db.ProductBrand.Find(itemId));
            db.SaveChanges();

        }

        public void Insert(ProductBrand item)
        {
            db.ProductBrand.Add(item);
            db.SaveChanges();
        }

        public List<ProductBrand> SelectAll()
        {
            return db.ProductBrand.ToList();
        }

        public ProductBrand SelectById(int itemId)
        {
            return db.ProductBrand.Find(itemId);
        }

        public void Update(ProductBrand item)
        {
            ProductBrand updated = db.ProductBrand.Find(item.BrandId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
