namespace DependencyInversion.Models
{
    public sealed class UserAccount
    {
        public UserAccount(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Email { get; }
        public string PhoneNumber { get; }
    }
}
