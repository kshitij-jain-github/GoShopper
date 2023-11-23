using GoShopper.Data;
using GoShopper.DataAccess.Repository.IRepository;
using GoShopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShopper.DataAccess.Repository
{
    internal class CategoryRepositroy : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _db;
        public CategoryRepositroy(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
           _db.Categories.Update(obj);  
        }
    }
}
