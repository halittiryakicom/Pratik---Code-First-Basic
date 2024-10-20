using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pratik___Code_First_Basic.Data.Entities;
using Pratik___Code_First_Basic.Data;

namespace Pratik___Code_First_Basic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly PatikaFirstDbContext _context;

        public GameController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAll()
        {
            return _context.Games.ToList();
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
