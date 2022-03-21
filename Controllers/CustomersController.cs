using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyVidly.Models;

namespace UdemyVidly.Controllers
{
    public class CustomersController : Controller
    {
        public ApplicationDbContext _context;

        // constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // dispose db context
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Costomers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        // GET: Customer Details
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
            return View(customer);
        }


        
    }
}