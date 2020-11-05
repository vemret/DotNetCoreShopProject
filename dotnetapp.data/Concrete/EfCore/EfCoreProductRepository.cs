using System.Collections.Generic;
using System.Linq;
using dotnetapp.data.Abstract;
using dotnetapp.entity;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product,AppContext>,IProductRepository
    {
        public int GetCountByCategory(string category)
        {
            using (var context = new AppContext()){
                var products = context
                .Products
                .Where(i=>i.IsApprove)
                .AsQueryable(); // asqueryble sorgu yaparken kriter eklemek için

                if(!string.IsNullOrEmpty(category)){
                   products = products
                                    .Include(i=>i.ProductCategories)
                                    .ThenInclude(i=>i.Category)
                                    .Where(i=>i.ProductCategories.Any(a=>a.Category.Url == category));

                }
                //ilgili kritere kaçtane dönen varsa döndürülüyor.
                //TotalItems Bilgisi Gönderiliyor
                return products.Count();
            }
        }

        public List<Product> GetHomePageProducts()
        {
            using(var context = new AppContext()){
               return context.Products
                    .Where(i=>i.IsApprove && i.IsHome).ToList();
           }
        }

    //     public List<Product> GetPopularProducts(){
    //        using(var context = new AppContext()){
    //            return context.Products.ToList();
    //        }
    //    }

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

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            using (var context = new AppContext()){
                var products = context
                .Products
                .Where(i=>i.IsApprove)
                .AsQueryable(); // asqueryble sorgu yaparken kriter eklemek için

                if(!string.IsNullOrEmpty(name)){
                   products = products
                                    .Include(i=>i.ProductCategories)
                                    .ThenInclude(i=>i.Category)
                                    .Where(i=>i.ProductCategories.Any(a=>a.Category.Url == name));

                }
                //skip ve take metodları gelen page sayısına göre skiple öteleyip 
                //take ile page size sayısında ürün çekilxek
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        public List<Product> GetSearchResult(string searchString)
        {
            using (var context = new AppContext()){
                var products = context
                .Products
                .Where(i=>i.IsApprove && (i.Name.ToLower().Contains(searchString.ToLower()) || i.Description.ToLower().Contains(searchString.ToLower())))
                .AsQueryable(); // asqueryble sorgu yaparken kriter eklemek için

            
                //ilgili kritere kaçtane dönen varsa döndürülüyor.
                //TotalItems Bilgisi Gönderiliyor
                return products.ToList();
            }
        }

    }
}