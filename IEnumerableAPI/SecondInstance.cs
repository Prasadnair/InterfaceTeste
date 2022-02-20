using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEnumerableAPI
{
    public class SecondInstance : IInstance
    {
        public string GetDetails()
        {
            return "From Second Instance";
        }

        InstanceEnum IInstance.GetType()
        {
            return InstanceEnum.Second;
        }
    }
}
