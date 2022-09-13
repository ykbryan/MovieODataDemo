using MovieOdataDemo.Models;

namespace MovieOdataDemo.Services
{
    public interface IMovieService
    {
        IQueryable<Movie> GetMovies();
    }
}