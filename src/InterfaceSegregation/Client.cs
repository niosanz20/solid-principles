namespace InterfaceSegregation
{
    using System;
    using InterfaceSegregation.Devices;
    using InterfaceSegregation.Models;
    using InterfaceSegregation.Services;

    /*
     * Interface Segregation Principle (ISP)
     *
     * Purpose / goal:
     * - Prefer small, focused interfaces over large interfaces that force classes to
     *   implement members they do not need.
     *
     * Problem it solves:
     * - Without ISP, a simple printer might be forced to implement Scan or Fax methods
     *   and throw NotSupportedException. That makes the contract dishonest.
     *
     * When to use:
     * - Use ISP when an interface has unrelated capabilities, when implementations leave
     *   methods empty, or when only some clients need certain members.
     *
     * In this example:
     * - InvoicePrintingService depends only on IPrintableDevice.
     * - DocumentArchiveService depends only on IScannableDevice.
     * - ComplianceSubmissionService depends only on IFaxDevice.
     */
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle Demo\n");

            var invoice = new Document(
                "INV-2026-0042",
                "Invoice for cloud subscription renewal");

            var receiptPrinter = new ReceiptPrinter();

            // ReceiptPrinter only prints. Because the service asks only for printing,
            // this simple device is not forced to pretend it can scan or fax.
            var invoicePrinter = new InvoicePrintingService(receiptPrinter);

            Console.WriteLine("Step 1: A print workflow depends only on printing.");
            invoicePrinter.PrintInvoice(invoice);

            var officeMachine = new MultiFunctionPrinter();

            // The same physical machine can be passed to different services because it
            // implements multiple small interfaces. Each service still sees only what it needs.
            var archiveService = new DocumentArchiveService(officeMachine);
            var complianceService = new ComplianceSubmissionService(officeMachine);

            Console.WriteLine("Step 2: A multi-function device can satisfy separate workflows.");
            archiveService.ArchiveSignedCopy(invoice);
            complianceService.Submit(invoice, "+1-555-0199");
        }
    }
}
