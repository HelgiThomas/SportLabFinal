using Inspinia_MVC5_SeedProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.ViewModels
{
    public class AthleteViewModel
    {
        public Athlete Athlete { get; set; }
        public List<Measurement> Measurements { get; set; }
    }
}