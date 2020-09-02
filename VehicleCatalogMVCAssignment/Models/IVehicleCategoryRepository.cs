using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public interface IVehicleCategoryRepository
    {
        IEnumerable<VehicleCategory> GetAllCategories { get; }
    }
}
