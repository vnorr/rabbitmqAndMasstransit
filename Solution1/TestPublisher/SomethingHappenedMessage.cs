using Contracts;
using System;

namespace TestPublisher
{
    public class SomethingHappenedMessage : SomethingHappened
    {
        public string What { get; set; }
        public DateTime When { get; set; }
    }
}
