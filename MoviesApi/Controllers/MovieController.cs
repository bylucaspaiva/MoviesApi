using Microsoft.AspNetCore.Mvc;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private statit List<Movie> movies = new List<Movie>();
        public void AddMovie(Movie movie)
        {

        }
    }
}
