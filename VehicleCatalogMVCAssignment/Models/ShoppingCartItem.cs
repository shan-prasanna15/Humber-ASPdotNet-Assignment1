using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleCatalogMVCAssignment.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Vehicle Vehicle { get; set; }
        public decimal Amount { get; set; }
        [Key]
        public string ShoppingCartId { get; set; }
    }
}
