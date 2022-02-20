using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTeste
{
    public class ShoppingCartEBay : IShoppingCart
    {
        public object GetCart()
        {
            return $"Items from ebay";
        }
    }
}
