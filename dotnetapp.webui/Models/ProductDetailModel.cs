using System.Collections.Generic;
using dotnetapp.entity;

namespace dotnetapp.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product {get; set; }
        public List<Category> Categories { get; set; }
    }
}