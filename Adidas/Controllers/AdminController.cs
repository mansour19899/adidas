using Adidas.Models.Repositores;
using Adidas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adidas.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListNewPerson()
        {
            PersonRepository blPerson = new PersonRepository();

            var list = blPerson.Where(p=>p.Checked==false).ToList();

            return View(list);
        }

        public ActionResult Info(int id = 5)
        {

            PersonRepository blPerson = new PersonRepository();
            JobRecordRepository blJob = new JobRecordRepository();
            RelationShipRepository blRelation = new RelationShipRepository();

            PersonInfo infoo = new PersonInfo();

            var t = blPerson.Find(id);
            var tt = blJob.Where(p => p.Person_FK == t.Id).ToList();
            var ttt = blRelation.Where(p => p.Person_FK == t.Id).ToList();
            infoo.Person = t;

            if (tt.Count() > 0)
                infoo.JobRecord1 = tt.ElementAt(0);
            if (tt.Count() > 1)
                infoo.JobRecord2 = tt.ElementAt(1);
            if (tt.Count() > 2)
                infoo.JobRecord3 = tt.ElementAt(2);

            if (ttt.Count() > 0)
                infoo.RelationShip1 = ttt.ElementAt(0);
            if (ttt.Count() > 1)
                infoo.RelationShip2 = ttt.ElementAt(1);
            if (ttt.Count() > 2)
                infoo.RelationShip3 = ttt.ElementAt(2);

            return View(infoo);
        }

        public ActionResult ListCheckedPerson()
        {
            PersonRepository blPerson = new PersonRepository();

            var list = blPerson.Where(p=>p.Checked==true).ToList();

            return View(list);
        }
    }
}