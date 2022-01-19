using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    class Vehicle
    {
        public Vehicle(IVehicleBuilder builder)
        {
            HP = builder.HP;
            Company = builder.Company;
            Model = builder.Model;
            RoadSpeed = builder.RoadSpeed;
            is4x4 = builder.Is4x4;
        }
        public int HP { get; }
        public string Company { get; }
        public string Model { get; }
        public int RoadSpeed { get; }
        public bool is4x4 { get; }

        public override string ToString()
        {
            return $"This is a {Company} {Model} with a {HP} HP, it can reach up to {RoadSpeed} kmph" + (is4x4 ? ", it supports 4x4" : ".");
        }
    }
}
