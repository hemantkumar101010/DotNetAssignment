

using DependencyInjectionAndMiddleware.Models;
using DependencyInjectionAndMiddleware.Repo.Interface;

namespace DependencyInjectionAndMiddleware.Repo
{
    public class MovieRepo: IMovieRepo
    {
        public List<Movie> GetAll() => new List<Movie>()
        {
            new Movie()
            {
                ID = 1,
                Title = "Soul",
                ReleaseDate = new DateOnly(2020, 12, 25),
                RuntimeMinutes = 100,
                Director = "Pete Docter"
            },
            new Movie()
            {
                ID = 2,
                Title = "Luca",
                ReleaseDate = new DateOnly(2021, 6, 18),
                RuntimeMinutes = 95,
                Director = "Enrico Casarosa"
            },
            new Movie()
            {
                ID = 3,
                Title = "Onward",
                ReleaseDate = new DateOnly(2020, 3, 6),
                RuntimeMinutes = 102,
                Director = "Dan Scanlon"
            },
            new Movie()
            {
                ID = 4,
                Title = "Coco",
                ReleaseDate = new DateOnly(2017, 11, 22),
                RuntimeMinutes = 105,
                Director = "Lee Unkrich"
            }
        };

        public Movie GetByID(int id)
        {
            var allMovies = GetAll();
            return allMovies.First(x => x.ID == id);
        }
    }
}
