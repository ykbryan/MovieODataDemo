using System;
using Microsoft.AspNetCore.Mvc;
using MovieOdataDemo.Databases;
using MovieOdataDemo.Models;
using MovieOdataDemo.Services;

namespace MovieOdataDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private MysqlContext _context;
        private readonly IMovieService _movieService;
        public MoviesController(MysqlContext context, IMovieService movieService)
        {
            _context = context;
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return Ok(_context.Movies);
        }
    }
}

