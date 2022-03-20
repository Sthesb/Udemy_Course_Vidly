using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVidly.Models;
using UdemyVidly.ViewModels;

namespace UdemyVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        // GET: movies/random

        public IEnumerable<Movie> GetMovies()
        {
            
            return new List<Movie>
            {
                new Movie { MovieId=1,  MovieName = "Shrek!"},
                new Movie { MovieId=2, MovieName = "Lord of the rings"}
            };
        }


        
    }
}