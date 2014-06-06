using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace self01.Models
{
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string flagTopLocation { get; set; }

        public int? topLocationID { get; set; }
        public virtual ICollection<Location> ChildLocations { get; set; }
        public virtual Location topLocation { get; set; }
    }

}