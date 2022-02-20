using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IEnumerableAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleController : ControllerBase
    {
        private IInstance _instance;
        public MultipleController(IEnumerable<IInstance> instances)
        {
            _instance = instances.Where(i => i.GetType() == InstanceEnum.First).FirstOrDefault();
        }

        [HttpGet]
        public string GetFirstInstance()
        {
           return _instance.GetDetails();
        }

    }
}