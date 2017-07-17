using Contracts;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSubscriber
{
    class SomethingHappenedConsumer : IConsumer<SomethingHappened>
    {
        public Task Consume(ConsumeContext<SomethingHappened> context)
        {
            Console.Write("TXT: " + context.Message.What);
            Console.Write("  SENT: " + context.Message.When);
            Console.Write("  PROCESSED: " + DateTime.Now);
            Console.WriteLine(" (" + System.Threading.Thread.CurrentThread.ManagedThreadId + ")");
            return Task.FromResult(0);
        }
    }
}
