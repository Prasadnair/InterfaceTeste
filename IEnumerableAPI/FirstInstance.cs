using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEnumerableAPI
{
    public class FirstInstance : IInstance
    {
        public string GetDetails()
        {
            return "From FirstInstance";
        }

        InstanceEnum IInstance.GetType()
        {
            return InstanceEnum.First;
        }
    }
}
