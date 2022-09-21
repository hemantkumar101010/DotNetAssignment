using DependencyInjectionAndMiddleware.Repo.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAndMiddleware.Controllers
{
    public class MovieController : Controller
    {

       
        readonly public IMovieRepo _movieRepo;

        // constructor dependency injected
        public MovieController(IMovieRepo movieRepo)
        {
            _movieRepo= movieRepo;
        }


        // GET: MovieController
        public ActionResult Index()
        {
            var list =  _movieRepo.GetAll();
            return  View(list);
        }



       
    }
}
