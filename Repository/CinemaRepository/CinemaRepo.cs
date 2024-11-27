using Microsoft.EntityFrameworkCore;
using Movie_System.DTOs;
using Movie_System.Models;

namespace Movie_System.Repository.CinemaRepository
{
    public class CinemaRepo: ICinemaRepo
    {
        private readonly AppDbContext _context;

        public CinemaRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(AddAllCinema addAllCinema)
        {
            Cinema cinema = new Cinema
            {
                Name = addAllCinema.Name,
                Placeholder = addAllCinema.Placeholder,
                Movies=addAllCinema.moviesDtos.Select(x => new Movie
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleasaYear,
                    Category =new Category
                    {
                        Name =x.categoryDto.Name,
                    }
                }).ToList(),
                
            };
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
        }

        public List<AddAllCinema> GetAll()
        {
            var res = _context.Cinemas.Include(x => x.Movies).ThenInclude(x => x.Category).Select(x => new AddAllCinema
            {
                Name = x.Name,
                Placeholder = x.Placeholder,
                moviesDtos = x.Movies.Select(x => new MoviesDto
                {
                    Title = x.Title,
                    ReleasaYear = x.ReleaseYear,
                    categoryDto = new CategoryDto
                    {
                        Name = x.Category.Name,
                    }
                }).ToList(),
            }).ToList();
            return res;
        }

        public void Update(AddAllCinema updateAllCinema, int id)
        {
            var res = _context.Cinemas
                .Include(x => x.Movies)
                .ThenInclude(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                res.Name = updateAllCinema.Name;
                res.Placeholder = updateAllCinema.Placeholder;
                res.Movies = updateAllCinema.moviesDtos.Select(x => new Movie
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleasaYear,
                    Category = new Category
                    {
                        Name = x.categoryDto.Name,
                    }
                }).ToList();
                _context.Cinemas.Update(res);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("NotFound");
            }
        }
    }
}









