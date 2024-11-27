using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_System.DTOs;
using Movie_System.Repository.MovieRepository;

namespace Movie_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _repo;

        public MovieController(IMovieRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(AddAll addAll)
        {
            _repo.Add(addAll);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            try
            {
                var res = _repo.GetById(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
