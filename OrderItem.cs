public class OrderItem
{
    public int OrderItemId { get; private set; }
    public string ProductName { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }

    public OrderItem(int orderItemId, string productName, int quantity, decimal unitPrice)
    {
        OrderItemId = orderItemId;
        ProductName = productName;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public decimal GetTotalPrice()
    {
        return Quantity * UnitPrice;
    }
}