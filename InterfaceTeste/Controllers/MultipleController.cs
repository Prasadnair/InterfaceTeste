using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleController : ControllerBase
    {
        private IShoppingCartRepository _shoppingCartRepository;
        public MultipleController(IShoppingCartRepository shoppingCartRepository)
        {
            this._shoppingCartRepository = shoppingCartRepository;
        }

        [HttpGet]
        public IEnumerable<string> GetAmazoneProducts()
        {
            return new string[] { "Cart", this._shoppingCartRepository.GetCart().ToString() };
        }

    }
}