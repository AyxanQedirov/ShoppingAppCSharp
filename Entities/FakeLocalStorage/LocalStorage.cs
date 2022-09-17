using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FakeLocalStorage
{
    public static class LocalStorage
    {        
        public static List<Product> GetAllProduct()
        {
            return new List<Product>()
            {
                new Product(){Id=1,Name="Samsung S10",Price=1500,StockUnit=5,Description="This is Phone",CategoryId=1},
                new Product(){Id=2,Name="Samsung S20",Price=1500,StockUnit=5,Description="This is Phone",CategoryId=1},
                new Product(){Id=3,Name="IPhone 10",Price=1500,StockUnit=5,Description="This is Phone",CategoryId=1},
                new Product(){Id=4,Name="Xiamomi 9",Price=1500,StockUnit=5,Description="This is Phone",CategoryId=1},
                new Product(){Id=5,Name="LG 1",Price=1500,StockUnit=5,Description="This is Phone",CategoryId=1},
                new Product(){Id=5,Name="Apple Tv",Price=1500,StockUnit=5,Description="This is Tv",CategoryId=2}
            };
        }

        public static List<Category> GetAllCategory()
        {
            return new List<Category>()
            {
                new Category(){Id=1,Name="Phone"},
                new Category(){Id=2,Name="TV"}
            };
        }

    }    
}
