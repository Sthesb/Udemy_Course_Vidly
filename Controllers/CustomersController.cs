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
        // GET: Costomers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        // GET: Customer Details
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.CustomerId == id);
            return View(customer);
        }


        // list of customers
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { CustomerId = 1, CustomerName = "Sthembiso Mathebula"},
                new Customer { CustomerId = 2, CustomerName = "Goodness Simelane"},
            };
        }
    }
}