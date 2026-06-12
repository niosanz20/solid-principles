namespace InterfaceSegregation.Contracts
{
    using InterfaceSegregation.Models;

    public interface IScannableDevice
    {
        ScannedDocument Scan(Document document);
    }
}
