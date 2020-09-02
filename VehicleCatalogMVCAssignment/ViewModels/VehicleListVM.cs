using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleCatalogMVCAssignment.Models;

namespace VehicleCatalogMVCAssignment.ViewModels
{
    public class VehicleListVM
    {        
        public IEnumerable<Vehicle> Vehicles  { get; set; }
        public string SelectedCategoryName { get; set; }
    }
}
