using System.ComponentModel.DataAnnotations;

namespace Movie_System.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Placeholder { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
