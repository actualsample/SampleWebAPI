using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Services
{
    public interface ISamurai : ICrud<Samurai>
    {
        IEnumerable<Samurai> GetByName(string name);
    }
}
