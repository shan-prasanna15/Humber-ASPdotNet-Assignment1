using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using VehicleCatalogMVCAssignment.Models;
using VehicleCatalogMVCAssignment.ViewModels;

namespace VehicleCatalogMVCAssignment.Controllers
{
    public class VehicleController : Controller
    {
        private IVehicleRepository _vehicleRepo;
        private IVehicleCategoryRepository _vehicleCategoryRepo;

        public VehicleController(IVehicleRepository vehicleRepository, IVehicleCategoryRepository vehicleCategoryRepository)
        {
            _vehicleRepo = vehicleRepository;
            _vehicleCategoryRepo = vehicleCategoryRepository;
        }
        
        public ViewResult List()
        {
            //return View(_vehicleRepo.GetAllVehicles);
            VehicleListVM vehicleListVM = new VehicleListVM
            {
                Vehicles = _vehicleRepo.GetAllVehicles,
                SelectedCategoryName = _vehicleCategoryRepo.GetAllCategories.ToList()[0].Name
            };
            return View(vehicleListVM);
        }

        public IActionResult Details(int id)
        {
            var vehicle = _vehicleRepo.GetVehicleByVinNo(id);
            return View(vehicle);
        }

    }
}
