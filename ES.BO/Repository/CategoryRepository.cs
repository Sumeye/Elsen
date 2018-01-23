
using ES.DALL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BO.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        ElsenOnlineEntities db = new ElsenOnlineEntities();
        public void Insert(Category item)
        {
            db.Category.Add(item);
            db.SaveChanges();

        }
        public void Update(Category item)
        {
            Category updated = db.Category.Find(item.CategoryId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public void Delete(int itemId)
        {
            db.Category.Remove(db.Category.Find(itemId));
            db.SaveChanges();

        }
        public List<Category> SelectAll()
        {
          return  db.Category.ToList();
        }

        public Category SelectById(int itemId)
        {
            return db.Category.Find(itemId);
        }


    }
}
