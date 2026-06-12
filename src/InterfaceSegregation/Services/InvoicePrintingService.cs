namespace InterfaceSegregation.Services
{
    using InterfaceSegregation.Contracts;
    using InterfaceSegregation.Models;

    public sealed class InvoicePrintingService
    {
        private readonly IPrintableDevice _printer;

        public InvoicePrintingService(IPrintableDevice printer)
        {
            _printer = printer;
        }

        public void PrintInvoice(Document invoice)
        {
            _printer.Print(invoice);
        }
    }
}
