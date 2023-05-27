using Marketplace.DataAccess.Data;
using Marketplace.DataAccess.Repository.IRepository;
using Marketplace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            
            var objFromDb=_db.Products.FirstOrDefault(p => p.Id == product.Id);
            if(objFromDb != null)
            {
                objFromDb.Title = product.Title;
                objFromDb.Price = product.Price;
                objFromDb.Location = product.Location;
                objFromDb.Description = product.Description;
                objFromDb.ProductionYear = product.ProductionYear;
                objFromDb.CreatedDate = product.CreatedDate;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.LastModified = DateTime.Now;  //Edit date
                if (objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
            }
            //_db.Products.Update(product);
        }
    }
}
