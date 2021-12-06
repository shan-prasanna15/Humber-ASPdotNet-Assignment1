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
            VehicleListVM vehicleListVM = new VehicleListVM
            {
                Vehicles = _vehicleRepo.GetAllVehicles,
                //SelectedCategoryName = _vehicleCategoryRepo.GetAllCategories.ToList()[0].Name
            };
            return View(vehicleListVM);
        }

        [Route("ShowVehicleDetails/{VinNo:int}")]
        public ViewResult ShowVehicleDetails(int VinNo)
        {
            Vehicle vehicle = _vehicleRepo.GetVehicleByVinNo(VinNo);
            return View(vehicle);
        }

        [Route("AddVehicle")]        
        public ViewResult AddVehicle()
        {
            List<VehicleCategory> vehicleCategories = new List<VehicleCategory>();
            vehicleCategories = _vehicleCategoryRepo.GetAllCategories.ToList();
            ViewBag.message = vehicleCategories;
            return View();
        }

        [Route("AddVehicle")]
        [HttpPost]
        public RedirectToActionResult AddVehicle(Vehicle vehicle)
        {
            _vehicleRepo.AddVehicle(vehicle);
            return RedirectToAction("List");
        }

    }
}
