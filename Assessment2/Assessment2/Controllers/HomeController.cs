using Assessment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment2.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create(FormOneViewModel model)
        {
            try
            {
                String FirstName = model.FirstName;
                String LastName = model.LastName;
                ViewBag.FullName = FirstName + " " + LastName;

                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}