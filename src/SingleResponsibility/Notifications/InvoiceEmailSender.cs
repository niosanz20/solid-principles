namespace SingleResponsibility.Notifications
{
    using System;

    public sealed class InvoiceEmailSender
    {
        public void Send(string recipientEmail, string invoice)
        {
            Console.WriteLine($"  Sent invoice email to {recipientEmail}.");
        }
    }
}
