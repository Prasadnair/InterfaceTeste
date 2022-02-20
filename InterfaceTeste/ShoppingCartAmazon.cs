using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTeste
{
    public class ShoppingCartAmazon : IShoppingCart
    {
        public object GetCart()
        {
            return $"grab items from Amazone";
        }
    }
}
