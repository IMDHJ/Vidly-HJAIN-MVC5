using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
                return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                //new Customer { id = 1, Name= "Himanshu Jain"},
                //new Customer { id = 2, Name = "Bhawna Jain"}
            };
            return customers;
        }
    }
}