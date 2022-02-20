using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTeste
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly Func<Carts, IShoppingCart> _shoppingCart;

        public ShoppingCartRepository(Func<Carts, IShoppingCart> shoppingCart)
        {
            this._shoppingCart = shoppingCart;
        }
        public object GetCart()
        {
            var obj = this._shoppingCart(Carts.Amazon);

            return obj.GetCart();
        }
    }
}
