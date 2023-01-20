using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        private static int id = 0;

        [HttpPost]
        public void AddMovie([FromBody] Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine(movie.Duration);
            Console.WriteLine(movie.Title);
            Movie.Id = id++;
        }

        [HttpGet]
        public IEnumerable<Movie> getMovies()
        {
            return movies;
        }
    }
}
