using System;

namespace Principles.SOLID.OpenClosed
{
    /*
     * Open/Closed Principle (OCP)
     *
     * Goal:
     * - Code should be open for extension but closed for modification.
     *
     * How it works:
     * - DiscountCalculator depends on IDiscountPolicy.
     * - To add a new discount, create a new policy class instead of editing DiscountCalculator.
     *
     * When to use:
     * - Use when behavior changes often, such as discounts, pricing rules, validation rules, or shipping rules.
     * - Avoid large if/switch blocks that must be edited every time a new rule appears.
     *
     * Newbie note:
     * - OCP usually uses interfaces, abstract classes, or strategy-like composition.
     */
    public static class OpenClosedDemo
    {
        public static void Run()
        {
            Console.WriteLine("Open/Closed Principle Demo\n");

            var calculator = new DiscountCalculator();

            Console.WriteLine("Step 1: Calculate using a regular customer policy.");
            Console.WriteLine($"  Final price: {calculator.Calculate(1000, new RegularCustomerDiscount()):C}");

            Console.WriteLine("Step 2: Extend behavior by passing a VIP policy. Calculator code stays unchanged.");
            Console.WriteLine($"  Final price: {calculator.Calculate(1000, new VipCustomerDiscount()):C}");
        }
    }

    public interface IDiscountPolicy
    {
        decimal Apply(decimal amount);
    }

    public sealed class RegularCustomerDiscount : IDiscountPolicy
    {
        public decimal Apply(decimal amount) => amount * 0.95m;
    }

    public sealed class VipCustomerDiscount : IDiscountPolicy
    {
        public decimal Apply(decimal amount) => amount * 0.80m;
    }

    public sealed class DiscountCalculator
    {
        public decimal Calculate(decimal amount, IDiscountPolicy policy)
        {
            Console.WriteLine($"  Using {policy.GetType().Name}.");
            return policy.Apply(amount);
        }
    }
}
