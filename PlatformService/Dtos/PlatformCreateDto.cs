using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    // Create Data Transfer Object (DTO)
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string  Cost { get; set; }        
    }
}
