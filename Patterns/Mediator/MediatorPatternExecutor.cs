using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    public class MediatorPatternExecutor : IPattern
    {
        public void run()
        {
            var plane = new Airplane("Boeing");
            var bridge = new AirportBridge("Heathrow");

            var mediator = new RadioChannel();
            mediator.Add(plane);
            mediator.Add(bridge);

            plane.Notify(bridge.Id, "Landing");

            bridge.Notify(plane.Id, "Clear for Landing");
        }
    }
}
