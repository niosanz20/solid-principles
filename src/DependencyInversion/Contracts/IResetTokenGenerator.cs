namespace DependencyInversion.Contracts
{
    using DependencyInversion.Models;

    public interface IResetTokenGenerator
    {
        string GenerateFor(UserAccount user);
    }
}
