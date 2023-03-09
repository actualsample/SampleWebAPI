using Microsoft.EntityFrameworkCore;
using SampleApp.BackendAPI.Data;
using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Services
{
    public class SamuraiServiceEF : ISamurai
    {
        private readonly AppDbContext _dbContext;
        public SamuraiServiceEF(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddSamuraiToBattle(int samuraiId, int battleId)
        {
            try
            {
                var samurai = _dbContext.Samurais.FirstOrDefault(s => s.Id == samuraiId);
                var battle = _dbContext.Battles.FirstOrDefault(b=>b.BattleId == battleId);
                if(samurai != null && battle != null)
                {
                    battle.Samurais.Add(samurai);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var deleteSamurai = GetById(id);
                _dbContext.Remove(deleteSamurai);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Samurai> GetAll()
        {
            var results = _dbContext.Samurais.OrderBy(x => x.Name).ToList();
            /*var results = from s in _dbContext.Samurais
                          orderby s.Name ascending
                          select s;*/
            return results;
        }

        public IEnumerable<Samurai> GetAllWithQuotes()
        {
            var results = _dbContext.Samurais.Include(s=>s.Quotes).ToList();
            return results;
        }

        public Samurai GetById(int id)
        {
            var result = _dbContext.Samurais.FirstOrDefault(x => x.Id == id);
            if (result == null)
                throw new Exception($"Data id {id} tidak ditemukan");
            return result;
        }

        public IEnumerable<Samurai> GetByName(string name)
        {
            var results = _dbContext.Samurais.Where(s=>s.Name.ToLower().Contains(name.ToLower())) 
                .OrderBy(s=>s.Name).ToList();
            /*var results = from s in _dbContext.Samurais
                          where s.Name.ToLower().Contains(name.ToLower())
                          orderby s.Name descending
                          select s;*/
            return results;
        }

        public Samurai Insert(Samurai obj)
        {
            try
            {
                _dbContext.Samurais.Add(obj);
                _dbContext.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Samurai Update(int id, Samurai obj)
        {
            try
            {
                var samurauUpdate = GetById(id);
                samurauUpdate.Name = obj.Name;
                _dbContext.SaveChanges();
                return samurauUpdate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
