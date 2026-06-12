namespace LiskovSubstitution
{
    using System;
    using LiskovSubstitution.Contracts;
    using LiskovSubstitution.Models;
    using LiskovSubstitution.Payments;
    using LiskovSubstitution.Services;

    /*
     * Liskov Substitution Principle (LSP)
     *
     * Purpose / goal:
     * - Any implementation of a contract should be usable wherever that contract is
     *   expected without surprising the caller.
     *
     * Problem it solves:
     * - Without LSP, code may compile but fail at runtime because a subtype throws
     *   NotSupportedException, ignores required behavior, or returns an invalid result.
     *
     * When to use:
     * - Use LSP when designing interfaces, base classes, inheritance, or plugin-style
     *   implementations that must be interchangeable.
     *
     * In this example:
     * - CheckoutService accepts IPaymentMethod.
     * - CreditCardPayment, DigitalWalletPayment, and BankTransferPayment all honor the
     *   same contract: they can pay for an order and return a receipt.
     */
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle Demo\n");

            var order = new Order("ORD-2026-1050", 500);
            var checkout = new CheckoutService();

            // The variable type is IPaymentMethod, not a concrete payment class.
            // That means checkout can work with any valid implementation.
            IPaymentMethod[] paymentMethods =
            {
                new CreditCardPayment(),
                new DigitalWalletPayment(),
                new BankTransferPayment()
            };

            Console.WriteLine("Step 1: Checkout code depends only on IPaymentMethod.");
            Console.WriteLine("Step 2: Every payment method can replace another without changing checkout.");
            foreach (var paymentMethod in paymentMethods)
            {
                // No special if statement is needed for each payment type. If one
                // implementation could not safely be used here, it would violate LSP.
                var receipt = checkout.Pay(order, paymentMethod);
                Console.WriteLine($"  {receipt}");
            }
        }
    }
}
