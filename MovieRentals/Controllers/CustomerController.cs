using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentals.Models;

namespace MovieRentals.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Random()
        {
            var customer = new Customer { id = 1, name = "Sudheer" };
            return View(customer);
        }
    }
}