
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Shopping App");
            Console.WriteLine("1:get all products ,2:add new product");

            int commandId = int.Parse(Console.ReadLine());

            if (commandId == 1)
                getAllProductScreen();

        }

        public static void getAllProductScreen()
        {

        }
    }
}
