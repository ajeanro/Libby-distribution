using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class CategoryRepositoryEf : ICategoryRepository
    {
        private readonly CustomerContext _DbContext;

        public CategoryRepositoryEf(CustomerContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Category NewCategory)
        {
            _DbContext.Add(NewCategory);

            _DbContext.SaveChanges();
        }

        public List<Category> CategoryList()
        {
            return _DbContext.Categories.ToList();
        }

        public void Delete(Category CategoryToDelete)
        {
            
        }

        public Category GetById(int Id)
        {
            return new Category();
        }

        public void Update(Category EditedCategory)
        {
            
        }
    }
}
