using DependencyInjectionAndMiddleware.Models;

namespace DependencyInjectionAndMiddleware.Repo.Interface
{
    public interface IMovieRepo
    {
        List<Movie> GetAll();
        Movie GetByID(int id);
    }
}
