using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    interface IMediator
    {
        void Add(IMediatedComponent comp);

        void Notify(string from, string to, string message);
    }
}
