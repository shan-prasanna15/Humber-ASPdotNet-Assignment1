using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class MockVehicleCategoryRepository : IVehicleCategoryRepository
    {
        public IEnumerable<VehicleCategory> GetAllCategories => new List<VehicleCategory> { 
            new VehicleCategory
            {
                ClassId = 1, 
                Name = "SUV",
                Description = "Utilitarian Vehicle with better ground clearance and go anywhere attitude"
            },
            new VehicleCategory
            {
                ClassId = 2, 
                Name = "Saloon",
                Description = "5 Door saloon cars with proper spacious two row seating"
            },
            new VehicleCategory
            {
                ClassId = 3, 
                Name = "Shooting Break",
                Description = "Estate cars with extended hoodline for greater space and capacity"
            },
            new VehicleCategory
            {
                ClassId = 4,
                Name = "Hatchback",
                Description = "5 Door short versions of Wagons with fun filled driving characteristics"
            },
        };
    }
}
