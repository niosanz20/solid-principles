namespace SingleResponsibility
{
    using System;
    using SingleResponsibility.Invoicing;
    using SingleResponsibility.Models;
    using SingleResponsibility.Notifications;
    using SingleResponsibility.Pricing;

    /*
     * Single Responsibility Principle (SRP)
     *
     * Purpose / goal:
     * - A class should have one clear responsibility and one main reason to change.
     *
     * Problem it solves:
     * - Without SRP, one class often calculates totals, formats invoices, sends emails,
     *   writes logs, and talks to databases. A change in any one of those areas can break
     *   unrelated behavior.
     *
     * When to use:
     * - Use SRP when a class is doing multiple jobs or when its name includes words like
     *   "Manager", "Processor", or "Helper" and it keeps growing.
     *
     * In this example:
     * - OrderTotalCalculator changes only when pricing rules change.
     * - InvoiceFormatter changes only when invoice text/layout changes.
     * - InvoiceEmailSender changes only when notification delivery changes.
     */
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle Demo\n");

            // The Order model represents business data only. It does not calculate,
            // format, or send anything.
            var order = new Order(
                "ORD-1001",
                "customer@example.com",
                new[]
                {
                    new OrderLine("Keyboard", 1, 120),
                    new OrderLine("Mouse", 2, 45)
                });

            // Each object below has one focused job. This is the heart of SRP.
            var calculator = new OrderTotalCalculator();
            var formatter = new InvoiceFormatter();
            var sender = new InvoiceEmailSender();

            Console.WriteLine("Step 1: Pricing is handled by the calculator.");
            var total = calculator.Calculate(order);

            Console.WriteLine("Step 2: Invoice formatting is handled by the formatter.");
            var invoice = formatter.Format(order, total);
            Console.WriteLine(invoice);

            // Sending the invoice is separate from creating its content. If email changes
            // to SMS or an API integration, pricing and formatting code stay untouched.
            Console.WriteLine("Step 3: Notification delivery is handled by the email sender.");
            sender.Send(order.CustomerEmail, invoice);

            Console.ReadKey();
        }
    }
}
