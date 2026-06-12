using System;

namespace Principles.SOLID.SingleResponsibility
{
    /*
     * Single Responsibility Principle (SRP)
     *
     * Goal:
     * - A class should have one reason to change.
     *
     * How it works:
     * - OrderCalculator only calculates totals.
     * - InvoicePrinter only prints invoices.
     * - EmailSender only sends email.
     *
     * When to use:
     * - Use when one class is doing too many unrelated jobs.
     * - Splitting responsibilities makes code easier to test, change, and understand.
     *
     * Newbie note:
     * - "One responsibility" does not mean one method. It means one focused purpose.
     */
    public static class SingleResponsibilityDemo
    {
        public static void Run()
        {
            Console.WriteLine("Single Responsibility Principle Demo\n");

            var order = new Order("ORD-1001", 2, 150);
            var calculator = new OrderCalculator();
            var printer = new InvoicePrinter();
            var emailSender = new EmailSender();

            Console.WriteLine("Step 1: OrderCalculator handles only price calculation.");
            var total = calculator.CalculateTotal(order);

            Console.WriteLine("Step 2: InvoicePrinter handles only invoice formatting/output.");
            printer.Print(order, total);

            Console.WriteLine("Step 3: EmailSender handles only notification delivery.");
            emailSender.Send(order.CustomerEmail, "Your invoice is ready.");
        }
    }

    public sealed class Order
    {
        public Order(string number, int quantity, decimal unitPrice)
        {
            Number = number;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string Number { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
        public string CustomerEmail { get; } = "customer@example.com";
    }

    public sealed class OrderCalculator
    {
        public decimal CalculateTotal(Order order) => order.Quantity * order.UnitPrice;
    }

    public sealed class InvoicePrinter
    {
        public void Print(Order order, decimal total)
        {
            Console.WriteLine($"  Invoice {order.Number}: {order.Quantity} item(s), Total = {total:C}");
        }
    }

    public sealed class EmailSender
    {
        public void Send(string email, string message)
        {
            Console.WriteLine($"  Email to {email}: {message}");
        }
    }
}
