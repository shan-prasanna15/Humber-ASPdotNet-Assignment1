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

        public RedirectToActionResult AddToShoppingCart(int VinNo)
        {
            var selectedVehicle = _vehicleRepository.GetVehicleByVinNo(VinNo);
            _shoppingCart.AddItemToCart(selectedVehicle, selectedVehicle.Amount);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int VinNo)
        {
             var selectedVehicle = _vehicleRepository.GetVehicleByVinNo(VinNo);
            _shoppingCart.RemoveItemFromCart(selectedVehicle);
            return RedirectToAction("Index");
        }
    }
}
