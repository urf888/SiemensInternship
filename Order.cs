public class Order
{
    public int OrderId { get; private set; }
    public int CustomerId { get; private set; }
    public string CustomerName { get; private set; }
    private List<OrderItem> _items;
    public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

    public Order(int orderId, int customerId, string customerName)
    {
        OrderId = orderId;
        CustomerId = customerId;
        CustomerName = customerName;
        _items = new List<OrderItem>();
    }

    public void AddItem(OrderItem item)
    {
        _items.Add(item);
    }

    public decimal CalculateFinalPrice()
    {
        decimal subtotal = _items.Sum(item => item.GetTotalPrice());

        if (subtotal > 500)
            return subtotal * 0.9m;

        return subtotal;
    }
}