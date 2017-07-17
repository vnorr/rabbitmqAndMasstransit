using MassTransit;
using MassTransit.Log4NetIntegration.Logging;
using System;
namespace TestSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Log4NetLogger.Use();
            var bus = Bus.Factory.CreateUsingRabbitMq(x =>
            {
                var host = x.Host(new Uri("rabbitmq://localhost/"), h => { });

                x.ReceiveEndpoint(host, "Payment_NewPayment", e =>
                  e.Consumer<SomethingHappenedConsumer>());
            });
            bus.Start();
            var text = Console.ReadLine();
            while (!string.IsNullOrEmpty(text))
            {
                    bus.Stop();
            }
            
        }
    }
}
