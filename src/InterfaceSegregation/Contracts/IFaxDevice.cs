namespace InterfaceSegregation.Contracts
{
    using InterfaceSegregation.Models;

    public interface IFaxDevice
    {
        void SendFax(Document document, string destinationNumber);
    }
}
