namespace LiskovSubstitution.Models
{
    public sealed class PaymentReceipt
    {
        public PaymentReceipt(string orderNumber, string provider, decimal amount, string referenceNumber)
        {
            OrderNumber = orderNumber;
            Provider = provider;
            Amount = amount;
            ReferenceNumber = referenceNumber;
        }

        public string OrderNumber { get; }
        public string Provider { get; }
        public decimal Amount { get; }
        public string ReferenceNumber { get; }

        public override string ToString()
        {
            return $"{Provider} paid {Amount:C} for {OrderNumber}. Ref: {ReferenceNumber}";
        }
    }
}
