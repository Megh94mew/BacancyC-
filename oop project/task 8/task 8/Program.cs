using System;
using System.Collections.Generic;
using System.Linq;

// Define the OrderItem class as described
public class OrderItem
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

// Define the Order class as described
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}

public class Program
{
    public static void Main()
    {
        // 1. Create sample data
        var orders = new List<Order>
        {
            new Order
            {
                OrderId = 1,
                CustomerName = "Alice",
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Laptop", Price = 999.99m },
                    new OrderItem { ProductName = "Mouse", Price = 25.50m }
                }
            },
            new Order
            {
                OrderId = 2,
                CustomerName = "Bob",
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Keyboard", Price = 75.00m },
                    new OrderItem { ProductName = "Monitor", Price = 250.00m },
                    new OrderItem { ProductName = "Desk Chair", Price = 150.00m }
                }
            },
            new Order
            {
                OrderId = 3,
                CustomerName = "Charlie",
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { ProductName = "Smartphone", Price = 700.00m }
                }
            }
        };

        // 2. LINQ Query: Fetch all product names
        // Method Syntax
        IEnumerable<string> allProductNamesMethod = orders
            .SelectMany(order => order.OrderItems)
            .Select(item => item.ProductName);

        // Query Syntax (equivalent to the above)
        IEnumerable<string> allProductNamesQuery = from order in orders
                                                   from item in order.OrderItems
                                                   select item.ProductName;

        // 3. Output the results
        Console.WriteLine("All Product Names:");
        foreach (var productName in allProductNamesMethod)
        {
            Console.WriteLine(productName);
        }
    }
}
