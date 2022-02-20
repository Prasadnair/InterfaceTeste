using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTeste
{
    public class ShoppingCartFlipCart : IShoppingCart
    {
        public object GetCart()
        {
            return $" Items from FlipCart";

        }
                
    }
}
