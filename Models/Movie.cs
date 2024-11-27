using System.ComponentModel.DataAnnotations;

namespace Movie_System.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public Category Category { get; set; }
        public Cinema Cinema { get; set; }
    }
}
