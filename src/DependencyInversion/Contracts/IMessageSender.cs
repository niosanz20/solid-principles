namespace DependencyInversion.Contracts
{
    using DependencyInversion.Models;

    public interface IMessageSender
    {
        void Send(UserAccount user, string message);
    }
}
