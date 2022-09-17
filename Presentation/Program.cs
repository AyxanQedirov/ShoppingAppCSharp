using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public class Program
    {
        public static ProductService productService = new ProductService();
        public static CategoryService categoryService=new CategoryService();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello Shopping App");
            Console.WriteLine("1:get all products ,2:get all phone, 3:get all tv");

            int commandId = int.Parse(Console.ReadLine());

            if (commandId == 1)
                getAllProductScreen();
            if (commandId == 2)
                getByCategoryScreen((int)CategoryEnum.Phone);
            if (commandId == 3)
                getByCategoryScreen((int)CategoryEnum.Tv);


            Console.ReadKey();
        }

        public static void getAllProductScreen()
        {
            List<Product> allProducts=productService.GetAll();

            foreach (var product in allProducts)
            {
                Console.WriteLine(String.Format("id: {0},name: {1},price: {2},desc: {3}", product.Id, product.Name, product.Price, product.Description));
            }
        }

        public static void getByCategoryScreen(int categoryId)
        {
            Category categoryForFilter = categoryService.GetById(categoryId);
            List<Product> filteredProduct = productService.GetByCategory(categoryForFilter);

            foreach(var product in filteredProduct)
            {
                Console.WriteLine(String.Format("id: {0},name: {1},price: {2},desc: {3}", product.Id, product.Name, product.Price, product.Description));
            }
        }
    
    }
}
