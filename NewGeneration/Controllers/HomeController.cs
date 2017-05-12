using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewGeneration.Models;

namespace NewGeneration.Controllers
{
    public class HomeController : Controller
    {
        PupilContext db = new PupilContext();

        public ActionResult Index()
        {
            IEnumerable<Pupil> pupils = db.Pupils;

            ViewBag.Pupils = pupils;

            return View();
        }

        [HttpGet]
        public ActionResult Add(int id)
        {
            ViewBag.PupilId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Parent parents)
        {
            parents.StartLearning = DateTime.Now;
            db.Parents.Add(parents);
            db.SaveChanges();
            return "Thanks, " + parents.Name + " " + parents.MiddleName + ", for begin learning!";
        }

    }
}