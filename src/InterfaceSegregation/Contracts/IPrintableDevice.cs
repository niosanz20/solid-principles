namespace InterfaceSegregation.Contracts
{
    using InterfaceSegregation.Models;

    public interface IPrintableDevice
    {
        void Print(Document document);
    }
}
