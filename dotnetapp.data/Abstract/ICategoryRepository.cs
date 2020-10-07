using System.Collections.Generic;
using dotnetapp.entity;

namespace dotnetapp.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}