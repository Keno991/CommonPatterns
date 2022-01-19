using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Builder
{
    public class BuilderPatternExecutor : IPattern
    {
        public void run()
        {
            Vehicle vehicle = CarFactory.Construct(new FastCarBuilder());
            Console.WriteLine(vehicle.ToString());

            vehicle = CarFactory.Construct(new SUVBuilder());
            Console.WriteLine(vehicle.ToString());

        }
    }
}
