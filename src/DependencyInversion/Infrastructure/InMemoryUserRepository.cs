namespace DependencyInversion.Infrastructure
{
    using System.Collections.Generic;
    using DependencyInversion.Contracts;
    using DependencyInversion.Models;

    public sealed class InMemoryUserRepository : IUserRepository
    {
        private readonly IDictionary<string, UserAccount> _users =
            new Dictionary<string, UserAccount>
            {
                ["ana@example.com"] = new UserAccount("ana@example.com", "+639171234567"),
                ["ben@example.com"] = new UserAccount("ben@example.com", "+639181112222")
            };

        public UserAccount GetByEmail(string email)
        {
            return _users[email];
        }
    }
}
