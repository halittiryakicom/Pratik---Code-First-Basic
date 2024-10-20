using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pratik___Code_First_Basic.Data;
using Pratik___Code_First_Basic.Data.Entities;

namespace Pratik___Code_First_Basic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly PatikaFirstDbContext _context;

        public MovieController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAll()
        {
            return _context.Movies.ToList();
        }

        public ActionResult<Movie> Add()
        {
            return Ok();
        }

        public ActionResult<Movie> Edit()
        {
            return Ok();
        }

        public ActionResult<Movie> Delete()
        {
            return Ok();
        }
    }
}
