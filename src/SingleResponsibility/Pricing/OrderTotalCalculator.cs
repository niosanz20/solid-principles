namespace SingleResponsibility.Pricing
{
    using System.Linq;
    using SingleResponsibility.Models;

    public sealed class OrderTotalCalculator
    {
        public decimal Calculate(Order order)
        {
            return order.Lines.Sum(line => line.Quantity * line.UnitPrice);
        }
    }
}
