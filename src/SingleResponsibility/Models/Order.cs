namespace SingleResponsibility.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class Order
    {
        public Order(string number, string customerEmail, IEnumerable<OrderLine> lines)
        {
            Number = number;
            CustomerEmail = customerEmail;
            Lines = lines.ToArray();
        }

        public string Number { get; }
        public string CustomerEmail { get; }
        public IReadOnlyCollection<OrderLine> Lines { get; }
    }
}
