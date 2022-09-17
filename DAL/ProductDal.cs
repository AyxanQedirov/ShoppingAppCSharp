using Entities;
using Entities.FakeLocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            return LocalStorage.GetAllProduct();
        }

        public Product GetById(int id)
        {
            Product result=new Product();

            foreach (var product in LocalStorage.GetAllProduct())
            {
                if (product.Id == id)
                {
                    result = product;
                    break;
                }
                    
            }

            return result;
        }

        public void Add(Product product)
        {
;            LocalStorage.GetAllProduct().Add(product);
        }
    }
}
