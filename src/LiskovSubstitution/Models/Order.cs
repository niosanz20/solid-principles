namespace LiskovSubstitution.Models
{
    public sealed class Order
    {
        public Order(string number, decimal total)
        {
            Number = number;
            Total = total;
        }

        public string Number { get; }
        public decimal Total { get; }
    }
}
