using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_System.DTOs;
using Movie_System.Repository.CinemaRepository;

namespace Movie_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaRepo _repo;

        public CinemaController(ICinemaRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(AddAllCinema addAllCinema)
        {
            _repo.Add(addAllCinema);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }
        [HttpPut("Update")]
        public IActionResult Update(AddAllCinema updateAllCinema, int id)
        {
            try
            {
                _repo.Update (updateAllCinema, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
