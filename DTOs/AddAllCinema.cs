using System.ComponentModel.DataAnnotations;

namespace Movie_System.DTOs
{
    public class AddAllCinema
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Placeholder { get; set; }
        public List<MoviesDto> moviesDtos { get; set; }
    }
}
