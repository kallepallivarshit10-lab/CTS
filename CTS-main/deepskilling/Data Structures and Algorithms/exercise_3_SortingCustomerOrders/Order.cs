public class Order
{
    public int OrderId { get; set; }

    public string CustomerName { get; set; }

    public double TotalPrice { get; set; }

    public Order(int orderId, string customerName, double totalPrice)
    {
        OrderId = orderId;
        CustomerName = customerName;
        TotalPrice = totalPrice;
    }

    public void Display()
    {
        System.Console.WriteLine(
            OrderId + " " +
            CustomerName + " " +
            TotalPrice);
    }
}
