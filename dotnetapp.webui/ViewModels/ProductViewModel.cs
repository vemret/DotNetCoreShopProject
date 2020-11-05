using System;
using System.Collections.Generic;
using dotnetapp.entity;

namespace dotnetapp.webui.ViewModels
{
    //bilgileri shopcontrollera gönderiliyor orada nesne oluşturuluyor
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemPerPage {get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        
        public int TotalPages(){   // virgul olmaması adına 10/3=4 olması için 10 urunu 3er li gösterince
            return (int)Math.Ceiling((decimal)TotalItems/ItemPerPage);
        }
    }
    public class ProductListViewModel
    {
        //bilgileri controllera gönderilecek
        public PageInfo PageInfo {get; set; }
        public List<Product> Products { get; set; }
    }
}