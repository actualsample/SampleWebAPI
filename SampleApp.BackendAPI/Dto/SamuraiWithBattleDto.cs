using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Dto
{
    public class SamuraiWithBattleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BattleReadDto> Battles { get; set; }
    }
}
