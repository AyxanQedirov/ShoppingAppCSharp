using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductService
    {
        public ProductDal productDal { get; set; }
        public ProductService()
        {
            productDal = new ProductDal();
        }
        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return productDal.GetById(id);
        }

        public void Add(Product product)
        {
            if(product.Price<1500)
                productDal.Add(product);
        }

        public List<Product> GetByCategory(Category category)
        {
            List<Product> result = new List<Product>();

            foreach ( var product in productDal.GetAll())
            {
                if(product.CategoryId==category.Id)
                    result.Add(product);
            }

            return result;
        }

    }
}
