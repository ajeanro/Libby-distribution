using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IProductRepository
    {
        List<Product> ProductList();
        Product GetById(int Id);
        void Add(Product NewProduct);
        void Update(Product EditedProduct);
        void Delete(Product ProductToDelete);
        IEnumerable<Product> GetByCategory(Category category);
    }
}
