public class OrderService
{
    public static string GetTopSpender(List<Order> orders)
{
    return orders
        .GroupBy(o => o.CustomerId)
        .Select(g => new
        {
            CustomerName = g.First().CustomerName,
            TotalSpent = g.Sum(o => o.CalculateFinalPrice())
        })
        .OrderByDescending(c => c.TotalSpent)
        .First()
        .CustomerName;
}

    public static Dictionary<string, int> GetPopularProducts(List<Order> orders)
    {
        return orders
            .SelectMany(o => o.Items)
            .GroupBy(item => item.ProductName)
            .ToDictionary(
                g => g.Key,
                g => g.Sum(item => item.Quantity)
            )
            .OrderByDescending(kvp => kvp.Value)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}