using System.Collections.Generic;
using dotnetapp.data.Abstract;
using dotnetapp.entity;

namespace dotnetapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, AppContext>, ICategoryRepository
    {
        public List<Category> GetPopularCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}