using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int Id)
        {
            var customer = new Customer {Name = "Customer 1", Id = Id};

            return View(customer);
        }
    }
}