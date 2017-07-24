using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inspinia_MVC5_SeedProject.Models;
using Inspinia_MVC5_SeedProject.ViewModels;

namespace Inspinia_MVC5_SeedProject.Controllers
{
    public class AthleteController : Controller
    {
        // GET: Athlete
        public ActionResult Index()
        {
            var athlete = new Athlete();

            athlete.Name = "Helgi Thomas Hallgrimsson";

            var measurements = new List<Measurement>
            {
                new Measurement {Name = "Hæð"},
                new Measurement {Name = "Þyngd"}
            };

            var viewModel = new AthleteViewModel
            {
                Athlete = athlete,
                Measurements = measurements
            };

            return View(viewModel);
        }
    }
}