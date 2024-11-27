using System.ComponentModel.DataAnnotations;

namespace Movie_System.DTOs
{
    public class CategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
