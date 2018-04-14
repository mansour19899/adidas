using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adidas.Models.EntityModels;
using Adidas.ViewModels;

namespace Adidas.Controllers
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

        [HttpGet]
        public ActionResult Register()
        {
          DateOfBirth date= new DateOfBirth();
            ViewBag.Day = date.DayList;
            ViewBag.Month = date.MonthList;
            ViewBag.Year = date.YearList;

            

            return View();
        }
        [HttpPost]
        public ActionResult Register(PersonInfo per)
        {
        
            return View();
        }

       
    }
}