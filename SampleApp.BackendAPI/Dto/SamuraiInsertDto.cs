using System.ComponentModel.DataAnnotations;

namespace SampleApp.BackendAPI.Dto
{
    public class SamuraiInsertDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
