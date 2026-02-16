//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Task_day_3
//{
//    public class Product
//    {
//        public int ProductId { get; set; }
//        public string ProductName { get; set; }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            List<Product> products = new List<Product>
//            {
//                new Product { ProductId = 1, ProductName = "Mobile"},
//                new Product { ProductId = 2, ProductName = "Headset"},
//                new Product { ProductId = 3, ProductName = "Keyboard"},
//                new Product { ProductId = 4, ProductName = "Laptop"},
//                new Product { ProductId = 5, ProductName = "Mouse"}
//            };

//            int beforeCount = products.Count();

//            var uniqueProductNames = products
//                                     .Select(p => p.ProductName)
//                                     .Distinct();

//            int afterCount = uniqueProductNames.Count();


//            Console.WriteLine($"Count before removing duplication: {beforeCount} : {afterCount}");

//            Console.WriteLine("\nUnique Product Name:");
//            Console.WriteLine(name);
//        }
//    }

//}

// Theory:

// The LinQ method i have used in the above code is distinct().
// I have used it to remove the duplicate values from a sequence.
// And to ensure each product, name appears once.
// Then I have used before and after concept for unique names


