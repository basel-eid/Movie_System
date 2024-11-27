using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_System.DTOs;
using Movie_System.Repository.CategoryRepository;

namespace Movie_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repo;

        public CategoryController(ICategoryRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(CategoryDto categoryDto)
        {
            _repo.Add(categoryDto);
            return Ok();
        }
        [HttpPut("Update")]
        public IActionResult Update(CategoryDto categoryDto, int id)
        {
            try
            {
                _repo.Update(categoryDto, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
