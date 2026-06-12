namespace OpenClosed.Services
{
    using OpenClosed.Models;
    using OpenClosed.Policies;

    public sealed class ShippingQuoteService
    {
        public ShippingQuote CreateQuote(Shipment shipment, IShippingRatePolicy policy)
        {
            var amount = policy.CalculateRate(shipment);

            return new ShippingQuote(policy.ServiceName, shipment.TrackingNumber, amount);
        }
    }
}
