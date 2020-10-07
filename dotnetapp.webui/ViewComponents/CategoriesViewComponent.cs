using System.Collections.Generic;
using dotnetapp.business.Abstract;
//using dotnetapp.webui.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapp.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        
        public CategoriesViewComponent(ICategoryService categoryService) //injection işlemi
        {
            this._categoryService=categoryService;
        }
         public IViewComponentResult Invoke(){
             if (RouteData.Values["category"]!=null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
             return View(_categoryService.GetAll());
         }
        
        
    }
}