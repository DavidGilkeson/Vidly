using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random 







        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};

            return View(movie); // calling the view method which is just a helper
            // method inherited from the base Controller class
            // This method lets us quickly create a view result 

            // return Content("Hello");

            //return HttpNotFound();

            //return new EmptyResult();

            //return RedirectToAction("Index", "Home", new {page =1, sortBy = "name"});


        }

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
