using System.ComponentModel.DataAnnotations;

namespace Movie_System.DTOs
{
    public class AddAll
    {
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public CategoryDto categoryDto { get; set; }
        public CinemaDto cinemaDto { get; set; }
    }
}
