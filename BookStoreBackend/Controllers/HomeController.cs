using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreBackend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            ViewBag.Title = "Home Page2";
            ViewBag.Name = "Books";
            ViewBag.Type = "BackEnd";
=======
            ViewBag.Title = "Home Page";
>>>>>>> Stashed changes
=======
            ViewBag.Title = "Home Page";
>>>>>>> Stashed changes

            return View();
        }
    }
}
