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

        public IActionResult List(string category){
            
            var productViewModel =new ProductListViewModel(){
                Products = _productService.GetProductsByCategory(category)
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
    }
}