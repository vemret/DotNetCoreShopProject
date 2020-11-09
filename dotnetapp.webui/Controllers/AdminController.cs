using dotnetapp.business.Abstract;
using dotnetapp.entity;
using dotnetapp.webui.Models;
using Microsoft.AspNetCore.Mvc;
namespace dotnetapp.webui.Controllers
{
    public class AdminController:Controller
    {
        //product bilgilerini çekmek için bir injection uygulandı
        private IProductService _productService;

        public AdminController(IProductService productService){
            _productService=productService;
        }
        public IActionResult productList()
        {
            return View(new ProductListViewModel(){
                Products= _productService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult createProduct(){
            return View();
        }

        //formu doldurup post işlemi kontrolu
        [HttpPost]
         public IActionResult createProduct(ProductModel model){

             var entity = new Product(){
                 Name = model.Name,
                 Url = model.Url,
                 Price = model.Price,
                 Description = model.Description,
                 ImageUrl = model.ImageUrl,
             };
            
            //form ile alınan product bilgileri entity nesnesine alınıp Create metoduyla iş katmanına oluşturma için gönderildi
             _productService.Create(entity);
            //postu alıp product lise dön
            return RedirectToAction("ProductList");
        }
    }
}