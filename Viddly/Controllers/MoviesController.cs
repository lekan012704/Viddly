using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddly.Models;

namespace Viddly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
// HEAD

        public MoviesController()
        {
        }

// 7e1c40d7cfec58e571a0a03d12162098b58296ae
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"
            };
            return View(movie);
        }
/// HEAD
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
    }

        public ActionResult Index(int? pageindex , string sortby)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";
          return  Content(String.Format("pageindex = {0} &sortby = {1}", pageindex, sortby));

        }
      
            [ActionName("Find")]
            public ActionResult GetById(int id)
            {
                // get student from the database 
                return View();
            }

        
        }

    
    }

}