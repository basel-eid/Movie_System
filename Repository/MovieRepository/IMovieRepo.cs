using Movie_System.DTOs;

namespace Movie_System.Repository.MovieRepository
{
    public interface IMovieRepo
    {
        public void Add(AddAll addAll);
        public List<AddAll> GetAll();
        public GetById GetById(int id);
    }
}
