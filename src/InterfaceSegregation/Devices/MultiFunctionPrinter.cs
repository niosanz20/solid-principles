namespace InterfaceSegregation.Devices
{
    using System;
    using InterfaceSegregation.Contracts;
    using InterfaceSegregation.Models;

    public sealed class MultiFunctionPrinter : IPrintableDevice, IScannableDevice, IFaxDevice
    {
        public void Print(Document document)
        {
            Console.WriteLine($"  Multi-function printer printed {document.ReferenceNumber}.");
        }

        public ScannedDocument Scan(Document document)
        {
            var storagePath = $"/archive/{document.ReferenceNumber}.pdf";
            Console.WriteLine($"  Multi-function printer scanned {document.ReferenceNumber} to {storagePath}.");

            return new ScannedDocument(document.ReferenceNumber, storagePath);
        }

        public void SendFax(Document document, string destinationNumber)
        {
            Console.WriteLine($"  Multi-function printer faxed {document.ReferenceNumber} to {destinationNumber}.");
        }
    }
}
