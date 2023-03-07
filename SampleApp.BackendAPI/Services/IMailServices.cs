namespace SampleApp.BackendAPI.Services
{
    public interface IMailServices
    {
        void Seed(string subject, string message);
    }
}
