namespace DependencyInversion.Infrastructure
{
    using System;
    using DependencyInversion.Contracts;
    using DependencyInversion.Models;

    public sealed class EmailMessageSender : IMessageSender
    {
        public void Send(UserAccount user, string message)
        {
            Console.WriteLine($"  Email to {user.Email}: {message}");
        }
    }
}
