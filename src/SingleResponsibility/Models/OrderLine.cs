namespace SingleResponsibility.Models
{
    public sealed class OrderLine
    {
        public OrderLine(string productName, int quantity, decimal unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string ProductName { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
    }
}
