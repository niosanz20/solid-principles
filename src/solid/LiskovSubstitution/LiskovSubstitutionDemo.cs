using System;
using System.Collections.Generic;

namespace Principles.SOLID.LiskovSubstitution
{
    /*
     * Liskov Substitution Principle (LSP)
     *
     * Goal:
     * - Child classes should be usable anywhere their parent type is expected.
     *
     * How it works:
     * - Code that works with IPaymentMethod should not care whether it receives CreditCardPayment or GCashPayment.
     * - Each implementation honors the same contract: Pay returns a successful payment message.
     *
     * When to use:
     * - Use when designing inheritance or interfaces.
     * - If a child class has to throw "not supported" for behavior promised by the parent, the design likely breaks LSP.
     *
     * Newbie note:
     * - LSP is not just about compiling. It is about subclasses behaving correctly through the base contract.
     */
    public static class LiskovSubstitutionDemo
    {
        public static void Run()
        {
            Console.WriteLine("Liskov Substitution Principle Demo\n");

            var payments = new List<IPaymentMethod>
            {
                new CreditCardPayment(),
                new GCashPayment()
            };

            Console.WriteLine("Step 1: Checkout code depends only on IPaymentMethod.");
            var checkout = new CheckoutService();

            Console.WriteLine("Step 2: Different payment implementations can be substituted safely.");
            foreach (var payment in payments)
            {
                checkout.Checkout(payment, 500);
            }
        }
    }

    public interface IPaymentMethod
    {
        string Pay(decimal amount);
    }

    public sealed class CreditCardPayment : IPaymentMethod
    {
        public string Pay(decimal amount) => $"Credit card paid {amount:C}.";
    }

    public sealed class GCashPayment : IPaymentMethod
    {
        public string Pay(decimal amount) => $"GCash paid {amount:C}.";
    }

    public sealed class CheckoutService
    {
        public void Checkout(IPaymentMethod paymentMethod, decimal amount)
        {
            Console.WriteLine($"  {paymentMethod.GetType().Name}: {paymentMethod.Pay(amount)}");
        }
    }
}
