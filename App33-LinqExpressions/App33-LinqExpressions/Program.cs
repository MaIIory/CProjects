using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App33_LinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo() { Name = "Kawa Nescafe", Description = "Kawa zbozowa rozpuszczalna", NumberInStock = 100 },
                new ProductInfo() { Name = "Mleko Laciate", Description = "Prosto od krowy", NumberInStock = 12 },
                new ProductInfo() { Name = "Platki Cornflakes", Description = "Zdrowe sniadanie", NumberInStock = 76 },
                new ProductInfo() { Name = "Kakao CoCoMoreno", Description = "Epickie Kakao", NumberInStock = 24 },
                new ProductInfo() { Name = "Woda Zrodlana", Description = "Prosto ze zrodla", NumberInStock = 99 },
                new ProductInfo() { Name = "Piwo Harnas", Description = "Tanio i dobrze", NumberInStock = 168 }
            };

            GetEverything(itemsInStock);
            GetProductNamesOnly(itemsInStock);
            GetOverStock(itemsInStock);
            GetNamesAndDescritpions(itemsInStock);

            var result = ReturnVarType(itemsInStock);
            foreach(var r in result)
                Console.WriteLine(r.ToString());

            GetNumberOfOverstockedProducts(itemsInStock);

            Console.ReadLine();
        }

        static void GetEverything(ProductInfo [] products)
        {
            Console.WriteLine("\n**** GetEverything ****");
            var allProducts = from p in products select p;

            foreach(var p in allProducts)
                Console.WriteLine(p.ToString());
        }

        static void GetProductNamesOnly(ProductInfo [] products)
        {
            Console.WriteLine("\n**** GetProductNamesOnly ****");
            var productNames = from p in products select p.Name;

            foreach(var p in productNames)
                Console.WriteLine(p.ToString());
        }

        static void GetOverStock(ProductInfo [] products)
        {
            Console.WriteLine("\n**** GetOverstock ****");
            var overstock = from product in products where product.NumberInStock > 25 select product.Name + ' ' + product.NumberInStock;
            
            foreach(var p in overstock)
                Console.WriteLine(p.ToString()); 
        }

        static void GetNamesAndDescritpions(ProductInfo [] products)
        {
            Console.WriteLine("\n**** GetNamesAndDescritpions ****");

            var namesAndDesc = from p in products select new { p.Name, p.Description };

            foreach(var p in namesAndDesc)
                Console.WriteLine(p.ToString());
        }

        //You cannot return 'var' type to the caller thus following method is not permitted:
        //static var ReturnVarIsNotPossible(ProductInfo [] products)
        //{
        //    return from p in products select p;
        //}

        //But you can tranform 'var' type into Array:
        static Array ReturnVarType(ProductInfo [] products)
        {
            Console.WriteLine("\n**** ReturnVarType ****");
            return (from p in products select p).ToArray();
        }

        static void GetNumberOfOverstockedProducts(ProductInfo [] products)
        {
            Console.WriteLine("\n**** GetNumberOfOverstockedProducts ****");
            int nb = (from p in products where p.NumberInStock > 25 select p).Count();

            Console.WriteLine("Number of overstocked products is : {0}",nb);
        }


    }
}
