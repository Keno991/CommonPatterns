using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    class FastCarBuilder : IVehicleBuilder
    {
        public int HP { get; private set; }
        public string Company { get; private set; }
        public string Model { get; private set; }
        public int RoadSpeed { get; private set; }
        public bool Is4x4 { get; private set; }

        public IVehicleBuilder SetVehicleInfo(string company, string model, int hp)
        {
            Company = company;
            Model = model;
            HP = hp;
            return this;
        }

        public IVehicleBuilder SetRoadSpeed(int roadSpeed)
        {
            RoadSpeed = roadSpeed;
            return this;
        }

        public IVehicleBuilder SetIs4x4(bool is4x4)
        {
            Is4x4 = is4x4;
            return this;
        }

        public Vehicle build()
        {
            return new Vehicle(this);
        }

        public IVehicleBuilder reset()
        {
            return new FastCarBuilder();
        }
    }
}
