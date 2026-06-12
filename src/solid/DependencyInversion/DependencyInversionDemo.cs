using System;

namespace Principles.SOLID.DependencyInversion
{
    /*
     * Dependency Inversion Principle (DIP)
     *
     * Goal:
     * - High-level code should depend on abstractions, not concrete low-level classes.
     *
     * How it works:
     * - PasswordResetService depends on IMessageSender.
     * - EmailMessageSender and SmsMessageSender are details that can be swapped.
     *
     * When to use:
     * - Use when business logic should not be tightly coupled to databases, email services, file systems, APIs, or frameworks.
     * - This makes code easier to test because fake implementations can be passed in.
     *
     * Newbie note:
     * - DIP is the principle. Dependency Injection is a common technique used to follow it.
     */
    public static class DependencyInversionDemo
    {
        public static void Run()
        {
            Console.WriteLine("Dependency Inversion Principle Demo\n");

            Console.WriteLine("Step 1: High-level service receives an abstraction: IMessageSender.");
            var emailService = new PasswordResetService(new EmailMessageSender());
            emailService.SendResetCode("ana@example.com", "123456");

            Console.WriteLine("Step 2: Swap to SMS without changing PasswordResetService.");
            var smsService = new PasswordResetService(new SmsMessageSender());
            smsService.SendResetCode("+639171234567", "654321");
        }
    }

    public interface IMessageSender
    {
        void Send(string destination, string message);
    }

    public sealed class EmailMessageSender : IMessageSender
    {
        public void Send(string destination, string message)
        {
            Console.WriteLine($"  Email to {destination}: {message}");
        }
    }

    public sealed class SmsMessageSender : IMessageSender
    {
        public void Send(string destination, string message)
        {
            Console.WriteLine($"  SMS to {destination}: {message}");
        }
    }

    public sealed class PasswordResetService
    {
        private readonly IMessageSender _messageSender;

        public PasswordResetService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendResetCode(string destination, string code)
        {
            _messageSender.Send(destination, $"Your reset code is {code}.");
        }
    }
}
