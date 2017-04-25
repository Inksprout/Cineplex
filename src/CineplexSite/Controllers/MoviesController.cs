using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineplexSite.Data;
using CineplexSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineplexSite.Controllers
{
    public class MoviesController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public MoviesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
           // getMovies();
            return View();
        }

        public IActionResult Sessions()
        {
            return View();
        }

//        private IEnumerable<Movie> getMovies()
//        {
//            // Movies = _applicationDbContext.Movies.ToList();
//        }
    }
}
