using System;

namespace PracticeDataStructAndALgo.LINQ
{
    public class Q3
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
                new Order { OrderId = 3, Customer = "Bob", Product = "Monitor", Price = 400m, OrderDate = new DateTime(2025, 2, 5) },
                new Order { OrderId = 4, Customer = "Bob", Product = "Phone", Price = 900m, OrderDate = new DateTime(2025, 2, 18) },
                new Order { OrderId = 5, Customer = "Charlie", Product = "Keyboard", Price = 150m, OrderDate = new DateTime(2025, 1, 12) },
                new Order { OrderId = 6, Customer = "Charlie", Product = "Monitor", Price = 350m, OrderDate = new DateTime(2025, 2, 25) }
            };
            //group orders by customer and get their total spending. 
            var orderDetails = orders.GroupBy(d => d.Customer).Select(d => new { Name = d.Key, TotalSpending = d.Sum(d => d.Price) });
            foreach (var i in orderDetails)
                Console.WriteLine($"Name:{i.Name} , TotalORder:{i.TotalSpending}");
        }       

    }
}