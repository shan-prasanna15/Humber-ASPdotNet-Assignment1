using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAllVehicles { get; }
        IEnumerable<Vehicle> ManualTransmissionVehicles { get; }
        Vehicle GetVehicleByVinNo(int VinNo);

        void AddVehicle(Vehicle vehicle);
    }
}
