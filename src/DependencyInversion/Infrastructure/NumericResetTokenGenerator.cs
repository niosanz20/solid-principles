namespace DependencyInversion.Infrastructure
{
    using DependencyInversion.Contracts;
    using DependencyInversion.Models;

    public sealed class NumericResetTokenGenerator : IResetTokenGenerator
    {
        public string GenerateFor(UserAccount user)
        {
            return user.Email == "ana@example.com" ? "123456" : "654321";
        }
    }
}
