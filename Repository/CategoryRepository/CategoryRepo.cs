using Movie_System.DTOs;
using Movie_System.Models;

namespace Movie_System.Repository.CategoryRepository
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;

        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(CategoryDto categoryDto)
        {
            Category category = new Category
            {
                Name = categoryDto.Name,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(CategoryDto categoryDto, int id)
        {
            var res = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                res.Name = categoryDto.Name;
                _context.Categories.Update(res);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
    }
}
