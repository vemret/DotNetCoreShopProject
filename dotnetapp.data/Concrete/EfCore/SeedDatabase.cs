using System.Linq;
using dotnetapp.entity;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new AppContext();

            if(context.Database.GetPendingMigrations().Count() == 0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }

            context.SaveChanges();
        }
        private static Category[] Categories= {
            new Category(){Name="Telefon",Url="telefon"},
            new Category(){Name="Bilgisayar",Url="bilgisayar"},
            new Category(){Name="Otomobil",Url="otomobil"},
            new Category(){Name="Beyaz Eşya",Url="beyaz-esya"}
        };
        private static Product[] Products= {
            new Product(){Name="Xiaomi note9",Url="xiaomi-note9",Price=2000,ImageUrl="indir.jfif",Description="supeeer loo",IsApprove=true},
            new Product(){Name="Xiaomi note7",Url="xiaomi-note8",Price=2050,ImageUrl="huawei.jfif",Description="supeeer loo",IsApprove=true},
            new Product(){Name="Xiaomi note8",Url="xiaomi-note7",Price=2900,ImageUrl="monster.jfif",Description="supeeer loo",IsApprove=false},
            new Product(){Name="Xiaomi note6",Url="xiaomi-note6",Price=2001,ImageUrl="iphone.jfif",Description="supeeer loo",IsApprove=true}
        };
        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]}
        };
    }
    
}