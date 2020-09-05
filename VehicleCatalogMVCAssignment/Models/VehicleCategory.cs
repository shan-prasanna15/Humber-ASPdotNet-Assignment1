using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehicleCatalogMVCAssignment.Models
{
    public class VehicleCategory
    {        
        public int VehicleCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}