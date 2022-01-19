using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    class RadioChannel : IMediator
    {
        private Dictionary<string, IMediatedComponent> participants = new Dictionary<string, IMediatedComponent>();
        public void Add(IMediatedComponent comp)
        {
            comp.mediator = this;
            participants.Add(comp.Id, comp);
        }

        public void Notify(string from, string to, string message)
        {
            var participant = participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
