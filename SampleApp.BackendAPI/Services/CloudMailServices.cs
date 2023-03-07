namespace SampleApp.BackendAPI.Services
{
    public class CloudMailServices : IMailServices
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;
        public CloudMailServices(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettings:mailToAddress"];
            _mailFrom = configuration["mailSettings:mailFromAddress"];
        }
        public void Seed(string subject, string message)
        {
            Console.WriteLine($"mail from {_mailFrom} to {_mailTo} with {nameof(CloudMailServices)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
