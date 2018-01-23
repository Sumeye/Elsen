using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class ImageRepository : IRepository<ProductImage>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Delete(int itemId)
        {
            db.ProductImage.Remove(db.ProductImage.Find(itemId));
            db.SaveChanges();
        }

        public void Insert(ProductImage item)
        {
            db.ProductImage.Add(item);
            db.SaveChanges();
        }

        public List<ProductImage> SelectAll()
        {
            return db.ProductImage.ToList();
        }

        public ProductImage SelectById(int itemId)
        {
            return db.ProductImage.Find(itemId);
        }

        public void Update(ProductImage item)
        {
            ProductSize updated = db.ProductSize.Find(item.ImageId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
