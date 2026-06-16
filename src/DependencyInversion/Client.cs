namespace DependencyInversion
{
    using System;
    using DependencyInversion.Infrastructure;
    using DependencyInversion.Services;

    /*
     * Dependency Inversion Principle (DIP)
     *
     * Purpose / goal:
     * - High-level business code should depend on abstractions, not directly on
     *   low-level details such as databases, email gateways, SMS providers, or files.
     *
     * Problem it solves:
     * - Without DIP, business logic becomes tightly coupled to infrastructure. Testing is
     *   harder, provider changes are expensive, and small infrastructure changes can break
     *   core workflows.
     *
     * When to use:
     * - Use DIP when a service needs external systems or replaceable details: repositories,
     *   message senders, payment gateways, storage providers, clocks, or token generators.
     *
     * In this example:
     * - PasswordResetService depends on IUserRepository, IResetTokenGenerator, and
     *   IMessageSender contracts.
     * - InMemoryUserRepository, NumericResetTokenGenerator, EmailMessageSender, and
     *   SmsMessageSender are replaceable infrastructure details.
     */
    public class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle Demo\n");

            // These are low-level details. In a real app they could be a database,
            // random token provider, SendGrid adapter, Twilio adapter, etc.
            var users = new InMemoryUserRepository();
            var tokenGenerator = new NumericResetTokenGenerator();
            var emailSender = new EmailMessageSender();

            // The high-level service receives dependencies through its constructor.
            // This is dependency injection, a common technique used to follow DIP.
            Console.WriteLine("Step 1: PasswordResetService is created with abstractions.");
            var passwordResetService = new PasswordResetService(users, tokenGenerator, emailSender);
            passwordResetService.SendResetInstructions("ana@example.com");

            // We can swap email for SMS without editing PasswordResetService.
            Console.WriteLine("Step 2: Swap the message sender without changing business logic.");
            var smsService = new PasswordResetService(users, tokenGenerator, new SmsMessageSender());
            smsService.SendResetInstructions("ben@example.com");
            
            Console.ReadKey();
        }
    }
}
