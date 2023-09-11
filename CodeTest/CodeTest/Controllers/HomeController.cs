using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModels;
using BusinessLogic;

namespace CodeTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            ViewBag.Title = "Users";
            List<Employee> emps = new List<Employee>();
             emps = BusinessLo

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
    }
}