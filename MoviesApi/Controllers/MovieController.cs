﻿using Microsoft.AspNetCore.Mvc;
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
            movie.Id = id++;
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0,[FromQuery] int take = 20)
        {
            return movies.Skip(skip).Take(take)
;       }

        [HttpGet("{id}")]
        public IActionResult GetMoviesById(int id)
        {
            var movie = movies.FirstOrDefault(movie => movie.Id == id);
            return movie != null ? Ok(movie) : NotFound();
        }
    }
}
