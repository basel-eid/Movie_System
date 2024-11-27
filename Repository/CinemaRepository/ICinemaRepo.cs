using Movie_System.DTOs;

namespace Movie_System.Repository.CinemaRepository
{
    public interface ICinemaRepo
    {
        public void Add(AddAllCinema addAllCinema);
        public List<AddAllCinema> GetAll();
        public void Update(AddAllCinema updateAllCinema, int id);


    }
}
