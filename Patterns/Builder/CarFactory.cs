using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    class CarFactory
    {
        public static Vehicle Construct(IVehicleBuilder builder)
        {

            if(builder.GetType() == typeof(FastCarBuilder))
                return builder.SetVehicleInfo("Ford", "Mustang", 500)
                  .SetRoadSpeed(300)
                  .build();
            if(builder.GetType() == typeof(SUVBuilder))
                return builder.SetVehicleInfo("Ford", "Kuga", 300)
                  .SetRoadSpeed(220)
                  .SetIs4x4(true)
                  .build();

            throw new NotImplementedException("builder does not exist");
        }
    }
}
