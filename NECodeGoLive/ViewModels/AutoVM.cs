﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class AutoVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle make (Ford, Chevy, Tesla, ...)")]
        public string Make { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a model (Explorer, F150, ...)")]
        public string Model { get; set; } = null!;

        [Range(1900, 2040, ErrorMessage = "Year ranges allowed 1900-2024")]
        public int Year { get; set; }

        public int Doors { get; set; }

        public bool IsAutomatic { get; set; } = true;

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
