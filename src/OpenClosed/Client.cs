namespace OpenClosed
{
    using System;
    using OpenClosed.Models;
    using OpenClosed.Policies;
    using OpenClosed.Services;

    /*
     * Open/Closed Principle (OCP)
     *
     * Purpose / goal:
     * - Code should be open for extension but closed for modification.
     *
     * Problem it solves:
     * - Without OCP, adding a new rule often means editing an existing service and adding
     *   another if/switch branch. Over time, that service becomes risky to change.
     *
     * When to use:
     * - Use OCP when behavior varies by rule, policy, type, provider, customer segment,
     *   country, payment method, shipping method, or similar business variation.
     *
     * In this example:
     * - ShippingQuoteService does not know the details of standard, express, or
     *   international pricing.
     * - New shipping policies can be added by creating another IShippingRatePolicy class.
     */
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Open/Closed Principle Demo\n");

            var shipment = new Shipment("SHP-2026-0091", 3.5m, "Singapore");

            // The service is stable. It receives a policy abstraction and delegates
            // variable pricing behavior to that policy.
            var quoteService = new ShippingQuoteService();

            Console.WriteLine("Step 1: Quote with a standard shipping policy.");
            Console.WriteLine($"  {quoteService.CreateQuote(shipment, new StandardShippingPolicy())}");

            // These new policies extend the behavior without editing ShippingQuoteService.
            Console.WriteLine("Step 2: Add express or international policies without editing the service.");
            Console.WriteLine($"  {quoteService.CreateQuote(shipment, new ExpressShippingPolicy())}");
            Console.WriteLine($"  {quoteService.CreateQuote(shipment, new InternationalShippingPolicy())}");
        }
    }
}
