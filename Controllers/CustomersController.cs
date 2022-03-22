using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using UdemyVidly.Models;
using UdemyVidly.ViewModels;

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



        // GET: customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType ).ToList();
            return View(customers);
        }

        // GET: customer/Details/{id}
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.CustomerId == id);
            return View(customer);
        }

        // GET: customers/create
        public ActionResult Create()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }


        // POST: customers/store
        [HttpPost]
        public ActionResult Store(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }


    }
}