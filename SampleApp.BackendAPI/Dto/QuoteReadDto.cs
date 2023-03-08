using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Dto
{
    public class QuoteReadDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SamuraiId { get; set; }
    }
}
