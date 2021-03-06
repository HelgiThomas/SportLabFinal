﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Result { get; set; }

        public virtual ICollection<Athlete> Athletes{ get; set; }
    }
}