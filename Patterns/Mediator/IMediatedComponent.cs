using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    interface IMediatedComponent
    {
        IMediator mediator { get; set; }
        string Id { get; set; }
        void Notify(string to, string message);
        void Receive( string from, string message);
    }
}
