namespace DependencyInversion.Infrastructure
{
    using System;
    using DependencyInversion.Contracts;
    using DependencyInversion.Models;

    public sealed class SmsMessageSender : IMessageSender
    {
        public void Send(UserAccount user, string message)
        {
            Console.WriteLine($"  SMS to {user.PhoneNumber}: {message}");
        }
    }
}
