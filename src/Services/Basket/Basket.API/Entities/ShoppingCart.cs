using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItems> Items{ get; set; }
        public ShoppingCart()
        {
            Items = new List<ShoppingCartItems>();
        }

        public ShoppingCart(string userName)
        {
            Items = new List<ShoppingCartItems>();
            UserName = userName;
        }

        public decimal TotalPrice {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                    totalPrice += item.Price*item.Quantity;
                return totalPrice;
            }
        }
    }
}
