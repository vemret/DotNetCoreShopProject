using System.Collections.Generic;
using System.Linq;
using dotnetapp.data.Abstract;
using dotnetapp.entity;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product,AppContext>,IProductRepository
    {
       public List<Product> GetPopularProducts(){
           using(var context = new AppContext()){
               return context.Products.ToList();
           }
       }

        public Product GetProductDetails(string url)
        {
            using(var context = new AppContext()){
               return context.Products
                                .Where(i=>i.Url==url)
                                .Include(i=>i.ProductCategories)
                                .ThenInclude(i=>i.Category)
                                .FirstOrDefault();
           }
        }

        public List<Product> GetProductsByCategory(string name)
        {
            using (var context = new AppContext()){
                var products = context.Products.AsQueryable(); // asqueryble sorgu yaparken kriter eklemek için

                if(!string.IsNullOrEmpty(name)){
                   products = products
                                    .Include(i=>i.ProductCategories)
                                    .ThenInclude(i=>i.Category)
                                    .Where(i=>i.ProductCategories.Any(a=>a.Category.Url == name));

                }
                return products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}