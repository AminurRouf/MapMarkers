using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IRISMap.Interfaces;
using IRISMap.Tasks;

namespace IRISMap.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly ILocationMapTasks _locationMapTasks;

        public HomeController(ILocationMapTasks locationMapTasks)
        {
            _locationMapTasks = locationMapTasks;
        }

        public ActionResult Index()
        {
        
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Your Map page.";
            var viewModel = _locationMapTasks.GetMapMarkers();

            return View(viewModel);
        }
    }
}