using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieC.Database;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieC.Controllers
{
    public class MovieController : Controller
    {
        //maybe add repository here?

        private readonly IMovieData _data;


        public MovieController(IMovieData data)
        {
            _data = data;
           
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchResultsGenre()
        {
            var display = _data.Get();
            return View(display);
        }

        public IActionResult SearchResultsTitle()
        {
            var display = _data.Get();
            return View(display);
        }
    }
}
