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

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "MovieName";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        // GET: movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { MovieName = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { CustomerName = "Sthembiso"},
                new Customer { CustomerName = "Goodness"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);


        }
        public ActionResult Edit(int id)
        {
            
            return Content("id " + id);
        }


        
    }
}