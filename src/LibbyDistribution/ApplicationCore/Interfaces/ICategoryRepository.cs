using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> CategoryList();
        Category GetById(int Id);
        void Add(Category NewCategory);
        void Update(Category EditedCategory);
        void Delete(Category CategoryToDelete);
    }
}
