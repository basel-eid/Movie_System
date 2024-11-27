using Movie_System.DTOs;

namespace Movie_System.Repository.CategoryRepository
{
    public interface ICategoryRepo
    {
        public void Add(CategoryDto categoryDto);
        public void Update(CategoryDto categoryDto, int id);
    }
}
