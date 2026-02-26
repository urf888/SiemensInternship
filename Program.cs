
var orders = new List<Order>
{
    new Order(1, 1, "Alice"),
    new Order(2, 2, "Bob"),
    new Order(3, 1, "Alice"),
    new Order(4, 3, "Charlie")
};

orders[0].AddItem(new OrderItem(1, "Laptop", 1, 300m));
orders[0].AddItem(new OrderItem(2, "Mouse", 2, 25m));

orders[1].AddItem(new OrderItem(3, "Phone", 1, 600m));
orders[1].AddItem(new OrderItem(4, "Headphones", 1, 100m));

orders[2].AddItem(new OrderItem(5, "Laptop", 1, 300m));
orders[2].AddItem(new OrderItem(6, "Keyboard", 1, 150m));

orders[3].AddItem(new OrderItem(7, "Mouse", 3, 25m));

// Test 2.2 - CalculateFinalPrice

foreach (var order in orders)
{
    Console.WriteLine($"Order {order.OrderId} ({order.CustomerName}): {order.CalculateFinalPrice():0.##}€");
}

// Test 2.3 - GetTopSpender

Console.WriteLine($"The customer who has spent the most money on all their orders: {OrderService.GetTopSpender(orders)}");

// Test 2.4 - GetPopularProducts

Console.WriteLine("\n Popular Products");
var popularProducts = OrderService.GetPopularProducts(orders);
foreach (var product in popularProducts)
{
    Console.WriteLine($"{product.Key}: {product.Value} quantity sold");
}