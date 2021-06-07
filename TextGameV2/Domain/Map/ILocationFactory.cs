using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Map
{
    public interface ILocationFactory
    {
        ILocation CreateLocation();
    }
}
