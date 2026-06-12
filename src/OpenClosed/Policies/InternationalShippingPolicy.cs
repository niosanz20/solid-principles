namespace OpenClosed.Policies
{
    using OpenClosed.Models;

    public sealed class InternationalShippingPolicy : IShippingRatePolicy
    {
        public string ServiceName => "International";

        public decimal CalculateRate(Shipment shipment)
        {
            return 25m + shipment.WeightInKg * 5m;
        }
    }
}
