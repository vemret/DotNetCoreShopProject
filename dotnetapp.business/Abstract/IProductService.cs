using System.Collections.Generic;
using dotnetapp.entity;

namespace dotnetapp.business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name);
        List<Product> GetAll(); //database tüm ürünleri getir
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}