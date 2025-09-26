namespace PracticeDataStructAndALgo.LINQ
{
    public class Q6
    {
        public class Order
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public List<OrderItem> OrderItems { get; set; }
        }


        public class OrderItem
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
        }

        public static void Run()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerName = "Alice", OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Laptop", Quantity = 1 },
                        new OrderItem { ProductName = "Mouse", Quantity = 2 }
                    }
                },
                new Order { OrderId = 2, CustomerName = "Bob", OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Keyboard", Quantity = 3 },
                        new OrderItem { ProductName = "Monitor", Quantity = 2 }
                    }
                },
                new Order { OrderId = 3, CustomerName = "Alice", OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Tablet", Quantity = 4 }
                    }
                },
                new Order { OrderId = 4, CustomerName = "Charlie", OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Phone", Quantity = 5 }
                    }
                }
            };

            //You are given a list of Order objects. Each order has an OrderId, CustomerName, and a list of OrderItems.
            //Each OrderItem has a ProductName and Quantity.
            //Write a LINQ query to find the top 3 customers who have ordered the highest total quantity of items across all their orders.
            //Return their names and total quantities.
            //expected output
            // Alice - 7
            // Charlie - 5
            // Bob - 5

            var topCustomers = orders
            .SelectMany(d => d.OrderItems, (d, item) => new { name = d.CustomerName, qunatity = item.Quantity })
            .GroupBy(l => l.name).Select(d => new { name = d.Key, q = d.Sum(l => l.qunatity) })
            .OrderByDescending(d => d.q)
            .Take(3);

            foreach (var item in topCustomers)
                Console.WriteLine($"{item.name} - {item.q}");

        }
    }
}