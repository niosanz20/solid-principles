namespace DependencyInversion.Services
{
    using DependencyInversion.Contracts;

    public sealed class PasswordResetService
    {
        private readonly IUserRepository _users;
        private readonly IResetTokenGenerator _tokenGenerator;
        private readonly IMessageSender _messageSender;

        public PasswordResetService(
            IUserRepository users,
            IResetTokenGenerator tokenGenerator,
            IMessageSender messageSender)
        {
            _users = users;
            _tokenGenerator = tokenGenerator;
            _messageSender = messageSender;
        }

        public void SendResetInstructions(string email)
        {
            var user = _users.GetByEmail(email);
            var token = _tokenGenerator.GenerateFor(user);

            _messageSender.Send(user, $"Your password reset code is {token}.");
        }
    }
}
