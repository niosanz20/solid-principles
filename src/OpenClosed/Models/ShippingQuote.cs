namespace OpenClosed.Models
{
    public sealed class ShippingQuote
    {
        public ShippingQuote(string serviceName, string trackingNumber, decimal amount)
        {
            ServiceName = serviceName;
            TrackingNumber = trackingNumber;
            Amount = amount;
        }

        public string ServiceName { get; }
        public string TrackingNumber { get; }
        public decimal Amount { get; }

        public override string ToString()
        {
            return $"{ServiceName} quote for {TrackingNumber}: {Amount:C}";
        }
    }
}
