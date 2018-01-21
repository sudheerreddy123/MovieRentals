using MovieRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult GetMovies()
        {
            var movie = new Movies() { Name = "Sudheer" };
            return View(movie);
        }
    }
}