namespace SampleApp.BackendAPI.Dto
{
    public class SamuraiWithQuotesReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<QuoteReadDto> Quotes { get; set; }
    }
}
