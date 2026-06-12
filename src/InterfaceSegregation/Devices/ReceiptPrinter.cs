namespace InterfaceSegregation.Devices
{
    using System;
    using InterfaceSegregation.Contracts;
    using InterfaceSegregation.Models;

    public sealed class ReceiptPrinter : IPrintableDevice
    {
        public void Print(Document document)
        {
            Console.WriteLine($"  Receipt printer printed {document.ReferenceNumber}: {document.Content}");
        }
    }
}
