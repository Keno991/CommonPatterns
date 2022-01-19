using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    interface IVehicleBuilder
    {
        int HP { get; }
        string Company { get; }
        string Model { get; }
        int RoadSpeed { get; }
        bool Is4x4 { get; }
        
        IVehicleBuilder reset();
        IVehicleBuilder SetVehicleInfo(string company, string model, int hp);
        IVehicleBuilder SetRoadSpeed(int roadSpeed);
        IVehicleBuilder SetIs4x4(bool is4x4);
        Vehicle build();
    }
}
