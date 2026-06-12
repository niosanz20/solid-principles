namespace DependencyInversion.Contracts
{
    using DependencyInversion.Models;

    public interface IUserRepository
    {
        UserAccount GetByEmail(string email);
    }
}
