using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    class Airplane : IMediatedComponent
    {
        public IMediator mediator { get; set; }
        public string Id { get; set; }

        public Airplane(string id)
        {
            Id = id;
        }

        public void Notify(string to, string message)
        {
            mediator.Notify(this.Id, to, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"{from}: {message}");
        }
    }
}
