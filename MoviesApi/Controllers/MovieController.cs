using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MoviesApi.Data;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _context.Movies.Add(movie);
            return CreatedAtAction(nameof(GetMovieById), new {id = movie.Id}, movie);
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0,[FromQuery] int take = 20)
        {
            return _context.Movies.Skip(skip).Take(take)
;       }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            return movie != null ? Ok(movie) : NotFound();
        }
    }
}
