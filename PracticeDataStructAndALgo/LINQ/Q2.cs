using System;

namespace PracticeDataStructAndALgo.LINQ
{
    public class Q2
    {
        public class Order
        {
            public int OrderId { get; set; }
            public string Customer { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public DateTime OrderDate { get; set; }
        }
        public static void Run()
        {
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, Customer = "Alice", Product = "Laptop", Price = 1200m, OrderDate = new DateTime(2025, 1, 15) },
                new Order { OrderId = 2, Customer = "Alice", Product = "Phone", Price = 800m, OrderDate = new DateTime(2025, 1, 20) },
                new Order { OrderId = 3, Customer = "Alice", Product = "Tablet", Price = 600m, OrderDate = new DateTime(2025, 2, 10) },
                new Order { OrderId = 4, Customer = "Bob", Product = "Laptop", Price = 1100m, OrderDate = new DateTime(2025, 1, 25) },
                new Order { OrderId = 5, Customer = "Bob", Product = "Monitor", Price = 400m, OrderDate = new DateTime(2025, 2, 5) },
                new Order { OrderId = 6, Customer = "Bob", Product = "Phone", Price = 900m, OrderDate = new DateTime(2025, 2, 18) },
                new Order { OrderId = 7, Customer = "Charlie", Product = "Keyboard", Price = 150m, OrderDate = new DateTime(2025, 1, 12) },
                new Order { OrderId = 8, Customer = "Charlie", Product = "Mouse", Price = 100m, OrderDate = new DateTime(2025, 1, 22) },
                new Order { OrderId = 9, Customer = "Charlie", Product = "Headphones", Price = 200m, OrderDate = new DateTime(2025, 2, 8) },
                new Order { OrderId = 10, Customer = "Charlie", Product = "Monitor", Price = 350m, OrderDate = new DateTime(2025, 2, 25) }
            };

            // Task:
            // Using LINQ, write a query that returns, for each customer, the most expensive product they bought in each month,
            // ordered by month (ascending) and then by price (descending).
            // The result should look like this:
            // Customer name
            // Month (e.g. 2025-09)
            // Product name
            // Price

            var query =
                from order in orders
                group order by new { order.Customer, Month = order.OrderDate.ToString("yyyy-MM") } into g
                let maxPrice = g.Max(o => o.Price)
                let mostExpensive = g.First(o => o.Price == maxPrice)
                orderby g.Key.Month, maxPrice descending
                select new
                {
                    Customer = g.Key.Customer,
                    Month = g.Key.Month,
                    Product = mostExpensive.Product,
                    Price = mostExpensive.Price
                };

            // Print results
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Customer,-8} | {item.Month} | {item.Product,-10} | ${item.Price}");
            }
        }   
    }
}