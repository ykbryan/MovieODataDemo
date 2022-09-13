using System;
using MovieOdataDemo.Models;

namespace MovieOdataDemo.Services
{
    public class MovieService : IMovieService
    {
        public MovieService()
        {
        }

        public IQueryable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}

