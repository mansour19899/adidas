using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adidas.Models.EntityModels;
using Adidas.Models.Repositores;
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
            per.Person.BirthDay = (per.Date.Year + "/" + per.Date.Month + "/" + per.Date.Day).ToGeorgianDateTime();
            per.Person.RegPerson = DateTime.Now;

            PersonRepository blPerson = new PersonRepository();

            //lPerson.Add(per.Person);
            return MessageBox.Show("با موفقیت ثبت شد", MessageType.Error);
            //return View();
        }


    }
}