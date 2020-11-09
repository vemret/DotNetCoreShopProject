using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        //burada name proportisini değiştirip bir placholder ekleyebiliriz
        [Display(Name="Name", Prompt="Prduct Name")]
        public string Name { get; set; }
        public string Url { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApprove{get;set;}
        public bool IsHome {get;set;}
    }
}