using System.Collections.Generic;
using dotnetapp.business.Abstract;
using dotnetapp.data.Abstract;
using dotnetapp.entity;

namespace dotnetapp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository){
            _categoryRepository=categoryRepository;
        }
        public void Create(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}