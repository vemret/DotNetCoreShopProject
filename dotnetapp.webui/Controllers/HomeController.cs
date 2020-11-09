using System.Collections.Generic;
using dotnetapp.business.Abstract;
using dotnetapp.data.Abstract;
//using dotnetapp.webui.Data;
using dotnetapp.entity;
using dotnetapp.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController:Controller
    {
        private IProductService _productService;
        
        public HomeController(IProductService productService) //injection işlemi
        {
            this._productService=productService;
        }
        //localhost:5001/home/index
        public IActionResult Index(){
        
            var productViewModel =new ProductListViewModel(){
                Products = _productService.GetHomePageProducts()
            };
            return View(productViewModel);
        }
        public IActionResult About(){
            return View();
        }
        public IActionResult Contact(){
            return View("MyView");
        }
        
    }
}