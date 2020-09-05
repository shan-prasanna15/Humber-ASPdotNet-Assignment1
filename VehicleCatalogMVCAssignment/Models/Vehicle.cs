using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class Vehicle
    {        
        public int VehicleID { get; set; }
        public int VinNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAutomaticTransmission { get; set; }
        public decimal Amount { get; set; }

        public VehicleCategory VehicleClass { get; set; }
    }
}
