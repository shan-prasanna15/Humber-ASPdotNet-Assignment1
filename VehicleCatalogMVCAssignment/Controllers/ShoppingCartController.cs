using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleCatalogMVCAssignment.Models;

namespace VehicleCatalogMVCAssignment.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IVehicleRepository vehicleRepository, ShoppingCart cart)
        {
            this._vehicleRepository = vehicleRepository;
            this._shoppingCart = cart;
        }

        public IActionResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            return View(_shoppingCart);
        }

        public RedirectToActionResult AddToShoppingCart(int VehicleId)
        {
            var selectedVehicle = _vehicleRepository.GetVehicleByVehicleId(VehicleId);
            _shoppingCart.AddItemToCart(selectedVehicle, selectedVehicle.Amount);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int VehicleId)
        {
             var selectedVehicle = _vehicleRepository.GetVehicleByVehicleId(VehicleId);
            _shoppingCart.RemoveItemFromCart(selectedVehicle);
            return RedirectToAction("Index");
        }
    }
}
