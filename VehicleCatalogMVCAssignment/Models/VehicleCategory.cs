using System.Collections.Generic;

namespace VehicleCatalogMVCAssignment.Models
{
    public class VehicleCategory
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}