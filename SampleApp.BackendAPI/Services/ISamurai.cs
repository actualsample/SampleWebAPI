using Newtonsoft.Json.Bson;
using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Services
{
    public interface ISamurai : ICrud<Samurai>
    {
        IEnumerable<Samurai> GetByName(string name);
        IEnumerable<Samurai> GetAllWithQuotes();
        Task AddSamuraiToBattle(int samuraiId, int battleId);
        Samurai GetSamuraiWithBattle(int samuraiId);
        Task<IEnumerable<Samurai>> GetAllSamuraiWithBattle();
        public void RemoveBattleFromSamurai(int samuraiId, int battleId);
    }
}
