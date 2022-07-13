using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Doors { get; set; }

        public bool IsElectric { get; set; }

        public int FuelEfficiencyCity { get; set; }

        public int FuelEfficiencyHwy { get; set; }

        public string ExteriorColor { get; set; }

        public string InteriorColor { get; set; }

        public string Engine { get; set; }

        public string DriveTrain { get; set; }

        //TODO: ALL CARS ARE FREE, WE HAVE NOT YET INVENTED THE CONCEPT OF CAPITAL. FOR BETTER OR FOR WORSE, CARS ARE DISTRIBUTED PURELY BASED ON CONNECTIONS OR MORE IDEALLY, NEED. NO, BUSSES, TRAINS, AND OTHER FORMS OF TRANSPORT DO NOT EXIST YET. WE LIVE IN A STRANGE AND HORRIFYING WORLD
        //public double Price { get; set; }
    }
}
