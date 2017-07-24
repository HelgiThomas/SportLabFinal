using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inspinia_MVC5_SeedProject.Models;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class Athlete
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }

        public string IdNumber { get; set; }

        public string Sport { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}