//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class OrderItem
//{
//    public string ProductName { get; set; }
//    public decimal Price { get; set; }

//}

//// Order class 

//public  class Order
//{
//    public int OrderId { get; set; }
//    public string CustomerName { get; set; }
//    public List<OrderItem> OrderItems { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Order> orders = new List<Order>
//        {
//            new Order
//            {
//                OrderId = 1,
//                CustomerName = "Megh",
//                OrderItems = new List<OrderItem>
//                {
//                    new OrderItem { ProductName = "Playstation", Price = 48000 },
//                    new OrderItem { ProductName = "keyboard", Price = 1320 }
//                }
//            },
//            new Order
//            {
//                OrderId = 2,
//                CustomerName = "Himanshu",
//                OrderItems = new List<OrderItem>

//                {
//                    new OrderItem { ProductName = "Mouse", Price = 500 },
//                    new OrderItem { ProductName = "Cpu", Price = 18300 }
//                }
//            }
//        };

//        var products = orders.SelectMany(o => o.OrderItems);

//        Console.WriteLine("Product Names:");
//        foreach (var item in products)

//        {
//            Console.WriteLine(item.ProductName);
//        }
//        int totalProductsSold = products.Count();
//        Console.WriteLine($"\nTotal Products Sold: {totalProductsSold}");
//    }
//}