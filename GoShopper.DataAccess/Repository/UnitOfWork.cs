using GoShopper.Data;
using GoShopper.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShopper.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _db;
        public  ICategoryRepository category { get;  private set; }    
        public UnitOfWork(AppDbContext db )
        {
            _db = db;
            Category = new CategoryRepository(_db);

        }
        public ICategoryRepository Category { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
