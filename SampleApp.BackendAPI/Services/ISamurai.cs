using Newtonsoft.Json.Bson;
using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Services
{
    public interface ISamurai : ICrud<Samurai>
    {
        IEnumerable<Samurai> GetByName(string name);
        IEnumerable<Samurai> GetAllWithQuotes();
        public void AddSamuraiToBattle(int samuraiId, int battleId);
        public Samurai GetSamuraiWithBattle(int samuraiId);
        public IEnumerable<Samurai> GetAllSamuraiWithBattle();
    }
}
