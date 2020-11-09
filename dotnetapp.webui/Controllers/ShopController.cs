using System.Linq;
using dotnetapp.business.Abstract;
using dotnetapp.entity;
using dotnetapp.webui.Models;

using Microsoft.AspNetCore.Mvc;

namespace dotnetapp.webui.Controllers
{
    public class ShopController:Controller
    {
        //Shop Controller
        private IProductService _productService;
        
        public ShopController(IProductService productService) //injection işlemi
        {
            this._productService=productService;
        }

        
        // local/host/products/categoryname?page=1 sayfalama
        //burada ana sayfaya düşen ürünleri sayfaladık
        public IActionResult List(string category, int page=1){
            //const bir değişkeni program boyunca sabit tutar
            const int pageSize=2;
            //productwievmodelde sınıfında tanımlı bilgileri aldık
            var productViewModel =new ProductListViewModel(){
                PageInfo = new PageInfo(){
                    // GetProductsByCategory ile Iporoductservice de yöntem üretildi
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category,page,pageSize)
            };
            return View(productViewModel);
        }

        public IActionResult Details(string url){
        
                if(url==null){
                    return NotFound();
                }
                Product product = _productService.GetProductDetails(url);

                if(product==null){
                    return NotFound();
                }
                return View(new ProductDetailModel{
                    Product = product,
                    Categories = product.ProductCategories.Select(id=>id.Category).ToList()
                });
            
        }

        public IActionResult Search(string q){
            var productViewModel = new ProductListViewModel{
                Products = _productService.GetSearchResult(q)
            };
            return View(productViewModel);
        }
    }
}