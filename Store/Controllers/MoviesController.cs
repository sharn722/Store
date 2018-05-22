using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;
using Store.Models.ViewModels;

namespace Store.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (sortBy == null)
            {
                sortBy = "Name";
            }

            return View();
            //return Content(String.Format("pageIndex={0}", pageIndex));
        }

        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Name = "Iron Man"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1", Id = 1},
                new Customer {Name = "Customer 2", Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("hi");
        }

        

    }
}