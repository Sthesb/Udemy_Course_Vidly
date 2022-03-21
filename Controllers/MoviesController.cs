using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using UdemyVidly.Models;
using UdemyVidly.ViewModels;

namespace UdemyVidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;

        // constructor
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // dispose db context
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Movies

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }


        // GET: movies/details/{id}
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.MovieId == id);

            return View(movie);
        }



    }
}