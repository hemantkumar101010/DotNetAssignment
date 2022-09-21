using DependencyInjectionAndMiddleware.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionAndMiddleware.Controllers
{

    //dependency injection : provides the objects that an another object needs .instead of having it construct the obj themselves
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //injecting dependent class object through constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}