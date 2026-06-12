namespace OpenClosed.Policies
{
    using OpenClosed.Models;

    public sealed class ExpressShippingPolicy : IShippingRatePolicy
    {
        public string ServiceName => "Express";

        public decimal CalculateRate(Shipment shipment)
        {
            return 15m + shipment.WeightInKg * 3.50m;
        }
    }
}
