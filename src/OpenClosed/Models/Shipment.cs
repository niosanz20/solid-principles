namespace OpenClosed.Models
{
    public sealed class Shipment
    {
        public Shipment(string trackingNumber, decimal weightInKg, string destinationCountry)
        {
            TrackingNumber = trackingNumber;
            WeightInKg = weightInKg;
            DestinationCountry = destinationCountry;
        }

        public string TrackingNumber { get; }
        public decimal WeightInKg { get; }
        public string DestinationCountry { get; }
    }
}
