using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class EFVehicleRepository : IVehicleRepository
    {
        private ApplicationDBContext appDBContext;

        public EFVehicleRepository(ApplicationDBContext appDbContext)
        {
            this.appDBContext = appDbContext;
        }

        public IEnumerable<Vehicle> GetAllVehicles {
            get
            {
                return appDBContext.Vehicles.Include(vc => vc.VehicleClass);
            }
        }

        public IEnumerable<Vehicle> ManualTransmissionVehicles => throw new NotImplementedException();

        public Vehicle GetVehicleByVinNo(int VinNo)
        {
            return appDBContext.Vehicles.Include(vc => vc.VehicleClass).FirstOrDefault(v => v.VinNo == VinNo);
        }
    }
}
