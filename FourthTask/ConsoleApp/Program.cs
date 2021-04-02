using ProductLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1 product1 = new Product1("Carrot", 20, 200);
            product1.Print();

            Product2 product2 = new Product2("Water melon", 50, 120, 2019);
            product2.Print();

            Console.ReadLine();
        }
    }
}
