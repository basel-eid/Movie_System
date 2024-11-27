namespace Movie_System.DTOs
{
    public class MoviesDto
    {
        public string Title { get; set; }
        public DateTime ReleasaYear { get; set; } 
        public CategoryDto categoryDto { get; set; }
    }
}
