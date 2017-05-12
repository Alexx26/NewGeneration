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

    }
}