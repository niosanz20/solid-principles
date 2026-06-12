namespace OpenClosed.Policies
{
    using OpenClosed.Models;

    public sealed class StandardShippingPolicy : IShippingRatePolicy
    {
        public string ServiceName => "Standard";

        public decimal CalculateRate(Shipment shipment)
        {
            return 8m + shipment.WeightInKg * 1.75m;
        }
    }
}
