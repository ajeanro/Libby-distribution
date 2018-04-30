using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class ProductRepositoryEf : IProductRepository
    {
        private readonly CustomerContext _DbContext;

        public ProductRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Product NewProduct)
        {
            
        }

        public void Delete(Product ProductToDelete)
        {
            
        }

        public IEnumerable<Product> GetByCategory(Category category)
        {
            return _DbContext.Products.Where(p => p.CategoryId == category.Id);
        }

        public Product GetById(int Id)
        {
            return _DbContext.Products.SingleOrDefault(p => p.Id == Id);
        }

        public List<Product> ProductList()
        {
            return _DbContext.Products.ToList();
        }

        public void Update(Product EditedProduct)
        {
            
        }
    }
}
