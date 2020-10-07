using System.Collections.Generic;
using dotnetapp.entity;
namespace dotnetapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name);
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}