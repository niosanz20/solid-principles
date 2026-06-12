namespace SingleResponsibility.Invoicing
{
    using System.Text;
    using SingleResponsibility.Models;

    public sealed class InvoiceFormatter
    {
        public string Format(Order order, decimal total)
        {
            var builder = new StringBuilder();

            builder.AppendLine($"  Invoice {order.Number}");
            foreach (var line in order.Lines)
            {
                builder.AppendLine($"  - {line.ProductName}: {line.Quantity} x {line.UnitPrice:C}");
            }

            builder.Append($"  Total: {total:C}");

            return builder.ToString();
        }
    }
}
