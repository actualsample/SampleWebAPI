using System.ComponentModel.DataAnnotations;

namespace SampleApp.BackendAPI.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage ="Anda harus menyediakan value")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
