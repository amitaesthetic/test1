using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using problem1.Helper;
using problem1.Model;
using problem1.Repo;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }


            ServiceProvider serviceProvider;
            IProductService service;
            DIHelper.DIForConsoleProgram(out serviceProvider, out service);

            int totalPrice = service.GetTotalPrice(products);

            Console.WriteLine(totalPrice);
            Console.ReadLine();


            serviceProvider.Dispose();

        }

        
    }
}
