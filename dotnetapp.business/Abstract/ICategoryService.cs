using System.Collections.Generic;
using dotnetapp.entity;

namespace dotnetapp.business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll(); //database tüm ürünleri getir
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}