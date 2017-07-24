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
            var athletes = GetAthletes();

            return View(athletes);
        }

        public ActionResult Details(int id)
        {
            var athlete = GetAthletes().SingleOrDefault(a => a.Id == id);

            if ( athlete == null)
            {
                return HttpNotFound();
            }

            return View(athlete);
        }

        private IEnumerable<Athlete> GetAthletes()
        {
            return new List<Athlete>
            {

                new Athlete {Id = 1, Name = "Helgi Thomas Hallgrímsson", IdNumber ="0809952889", Sport ="Crossfit" , Team = "Crossfit Reykjavík"},

                new Athlete {Id = 2, Name = "Thomas Geir Malla", IdNumber ="1509952889", Sport ="Badmitton" , Team = "Fjolnir"},


                new Athlete {Id = 3, Name = "Heimir Bjarnarson", IdNumber ="0812952889", Sport ="Kvikmynd" , Team = "Skot"}
            };
              
        }
    }
}