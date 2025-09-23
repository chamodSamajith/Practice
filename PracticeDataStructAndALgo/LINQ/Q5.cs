using System;

namespace PracticeDataStructAndALgo.LINQ
{
    public class Q5
    {
        public class Order
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public DateTime OrderDate { get; set; }
            public List<OrderItem> OrderItems { get; set; }
        }
        public class OrderItem
        {
            public int OrderId { get; set; }   // <-- Add OrderId to link with Order
            public string ProductName { get; set; }
            public int Quantity { get; set; }
        }

        public static void Run()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerName = "Alice", OrderDate = new DateTime(2025, 1, 12) },
                new Order { OrderId = 2, CustomerName = "Bob", OrderDate = new DateTime(2025, 2, 5) },
                new Order { OrderId = 3, CustomerName = "Alice", OrderDate = new DateTime(2025, 3, 15) },
                new Order { OrderId = 4, CustomerName = "Charlie", OrderDate = new DateTime(2025, 4, 10) }
            };


            var orderItems = new List<OrderItem>
            {
                new OrderItem { OrderId = 1, ProductName = "Laptop", Quantity = 2 },
                new OrderItem { OrderId = 1, ProductName = "Mouse", Quantity = 5 },
                new OrderItem { OrderId = 2, ProductName = "Keyboard", Quantity = 3 },
                new OrderItem { OrderId = 2, ProductName = "Monitor", Quantity = 1 },
                new OrderItem { OrderId = 3, ProductName = "Laptop", Quantity = 1 },
                new OrderItem { OrderId = 3, ProductName = "Monitor", Quantity = 2 },
                new OrderItem { OrderId = 4, ProductName = "Mouse", Quantity = 4 },
                new OrderItem { OrderId = 4, ProductName = "Keyboard", Quantity = 2 }
            };

            //find the top  3 customers who ordered the highest total quantity of products across all their orders.
            var topcus = orders.Join(orderItems, o => o.OrderId, oi => oi.OrderId, (o, oi) => new { o, oi })
            .GroupBy(d => d.o.CustomerName)
            .Select(d => new { customer = d.Key, totalQuantity = d.Sum(l => l.oi.Quantity) })
            .OrderByDescending(d => d.totalQuantity)
            .Take(3);

            foreach (var i in topcus)
                Console.WriteLine($"Customer: {i.customer} quantity: {i.totalQuantity}");


        }
    }
}