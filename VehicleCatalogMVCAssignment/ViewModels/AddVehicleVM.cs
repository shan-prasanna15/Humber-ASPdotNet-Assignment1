using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleCatalogMVCAssignment.Models;

namespace VehicleCatalogMVCAssignment.ViewModels
{
    public class AddVehicleVM
    {
        public Vehicle NewVehicle { get; set; }
        public int SelectedCategory { get; set; }
    }
}
