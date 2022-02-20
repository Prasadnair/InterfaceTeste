using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEnumerableAPI
{
    public interface IInstance
    {
        InstanceEnum GetType();

        string GetDetails();

    }
}
