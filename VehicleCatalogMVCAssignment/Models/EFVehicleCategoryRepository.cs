using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class EFVehicleCategoryRepository : IVehicleCategoryRepository
    {
        private ApplicationDBContext appDBContext;

        public EFVehicleCategoryRepository(ApplicationDBContext appDbContext)
        {
            this.appDBContext = appDbContext;
        }

        public IEnumerable<VehicleCategory> GetAllCategories
        {
            get
            {
                return this.appDBContext.VehicleCategories;
            }
        }

        public VehicleCategory GetVehicleCategoryById(int VehicleCategoryId) 
        {         
                return this.appDBContext.VehicleCategories.FirstOrDefault(x => x.VehicleCategoryID == VehicleCategoryId);         
        }
    }
}
