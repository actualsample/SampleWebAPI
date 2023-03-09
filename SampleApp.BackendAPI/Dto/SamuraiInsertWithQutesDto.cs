using System.ComponentModel.DataAnnotations;

namespace SampleApp.BackendAPI.Dto
{
    public class SamuraiInsertWithQutesDto
    {
        public string Name { get; set; }
        public List<QuoteInsertDto> Quotes { get; set; }
    }
}
