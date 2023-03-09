using Microsoft.EntityFrameworkCore;
using SampleApp.BackendAPI.Data;
using SampleApp.BackendAPI.Models;
using Serilog;
using SQLitePCL;
using System.Collections;

namespace SampleApp.BackendAPI.Services
{
    public class SamuraiServiceEF : ISamurai
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<SamuraiServiceEF> _loger;

        public SamuraiServiceEF(AppDbContext dbContext,ILogger<SamuraiServiceEF> logger)
        {
            _dbContext = dbContext;
            _loger = logger;
        }

        public async Task AddSamuraiToBattle(int samuraiId, int battleId)
        {
            try
            {
                var samurai = await _dbContext.Samurais.FirstOrDefaultAsync(s => s.Id == samuraiId);
                var battle = await _dbContext.Battles.FirstOrDefaultAsync(b=>b.BattleId == battleId);

                //_loger.LogInformation($"{samurai.Name} - {battle.Name}");
                if(samurai != null && battle != null)
                {
                    battle.Samurais = new List<Samurai>();
                    battle.Samurais.Add(samurai);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} - {ex.InnerException.Message}");
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
            var results = _dbContext.Samurais.OrderBy(x => x.Name).AsNoTracking().ToList();
            /*var results = from s in _dbContext.Samurais
                          orderby s.Name ascending
                          select s;*/
            return results;
        }

        public async Task<IEnumerable<Samurai>> GetAllSamuraiWithBattle()
        {
            var samurai = await _dbContext.Samurais.Include(s => s.Battles).ToListAsync();
            return samurai;
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

        public Samurai GetSamuraiWithBattle(int samuraiId)
        {
            var samurai = _dbContext.Samurais.Include(s => s.Battles).FirstOrDefault(s=>s.Id==samuraiId);
            if (samurai == null)
                throw new Exception($"Samurai {samuraiId} not found");
            return samurai;
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

        public void RemoveBattleFromSamurai(int samuraiId, int battleId)
        {
            try
            {
                var battleWithSamurai = _dbContext.Battles.Include(b => b.Samurais.FirstOrDefault(s => s.Id == samuraiId))
                    .FirstOrDefault(b=>b.BattleId==battleId);
                if(battleWithSamurai == null)
                    throw new Exception($"Data battle id {battleId} tidak ditemukan");
                var samurai = battleWithSamurai.Samurais[0];
                battleWithSamurai.Samurais.Remove(samurai);
                _dbContext.SaveChanges();
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
