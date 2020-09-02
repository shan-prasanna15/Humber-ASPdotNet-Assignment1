using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class Vehicle
    {
        public int VinNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAutomaticTransmission { get; set; }

        public VehicleCategory VehicleClass { get; set; }
    }
}
