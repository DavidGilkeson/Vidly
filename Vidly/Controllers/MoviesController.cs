using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random 







        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}


            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

            return View(viewModel);

        }
    }
}

/**
var viewResult = new ViewResult();

viewResult.ViewData.Model


return View(movie); //Whatever is passed here is assigned to .Model(property)

// calling the view method which is just a helper
// method inherited from the base Controller class
// This method lets us quickly create a view result 

// return Content("Hello");

//return HttpNotFound();

//return new EmptyResult();

//return RedirectToAction("Index", "Home", new {page =1, sortBy = "name"});


}

[Route("movies/released/{year}/month:regex(\\d{4}):range(1,12)}")] //pass the URL template

public ActionResult ByReleaseDate(int year, int month)
{
    return Content(year + "/" + month);
}


}

}

/**
*

public ActionResult Edit(int id)
{

return Content("id=" + id); 
}
//movies
public ActionResult Index(int? pageIndex, string sortBy)
{
if (pageIndex.HasValue)
pageIndex = 1;

if (String.IsNullOrWhiteSpace(sortBy))
sortBy = "Name";

return Content(String.Format("pageIndex={0}&sortBy={1}" , pageIndex, sortBy));
}
}
**/
