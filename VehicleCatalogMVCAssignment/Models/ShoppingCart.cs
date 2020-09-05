using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class ShoppingCart
    {
        private ApplicationDBContext _appContextDb;

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }


        public ShoppingCart(ApplicationDBContext appContextDb)
        {
            this._appContextDb = appContextDb;
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            string ShoppingCartId = session.GetString("ShoppingCartId") ??   Guid.NewGuid().ToString();
            session.SetString("ShoppingCartId", ShoppingCartId);

            var context = services.GetService<ApplicationDBContext>();
            return new ShoppingCart(context) { ShoppingCartId = ShoppingCartId };
            
        }

        public void AddItemToCart(Vehicle vehicle, decimal amount)
        {
            var ShoppingCartItem = _appContextDb.ShoppingCartItems.SingleOrDefault(
                                    s => s.Vehicle.VehicleID == vehicle.VehicleID
                                    && s.ShoppingCartId == this.ShoppingCartId
                                    );
            if(ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = this.ShoppingCartId,
                    Vehicle = vehicle,
                    Amount = amount
                };
                _appContextDb.ShoppingCartItems.Add(ShoppingCartItem);                
            }
            _appContextDb.SaveChanges();
        }

        public void RemoveItemFromCart(Vehicle v)
        {
            var ShoppingCartItem = _appContextDb.ShoppingCartItems.SingleOrDefault(
                s => s.Vehicle.VehicleID == v.VehicleID
                &&
                s.ShoppingCartId == this.ShoppingCartId
            );

            if(ShoppingCartItem != null)
            {
                _appContextDb.ShoppingCartItems.Remove(ShoppingCartItem);
            }
            _appContextDb.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            this.ShoppingCartItems = _appContextDb.ShoppingCartItems.Where(v => v.ShoppingCartId == this.ShoppingCartId).Include(v => v.Vehicle).ToList();
            return this.ShoppingCartItems;
        }

        public decimal GetShoppingCartTotal()
        {
            return _appContextDb.ShoppingCartItems.Where(s=> s.ShoppingCartId == this.ShoppingCartId).Select(v=> v.Amount).Sum();
        }

        public void ClearShoppingCart()
        {
            var ShoppingCartItems = _appContextDb.ShoppingCartItems.Where(c => c.ShoppingCartId == this.ShoppingCartId);
            _appContextDb.ShoppingCartItems.RemoveRange(ShoppingCartItems);
            _appContextDb.SaveChanges();
        }
    }
}
