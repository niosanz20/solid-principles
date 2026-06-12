namespace OpenClosed.Policies
{
    using OpenClosed.Models;

    public interface IShippingRatePolicy
    {
        string ServiceName { get; }
        decimal CalculateRate(Shipment shipment);
    }
}
