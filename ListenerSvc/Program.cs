using Core;
using Core.Events;
using MassTransit;
using Microsoft.Extensions.Configuration;
using ListenerSvc.Consumers;
using System;
using System.Threading.Tasks;

namespace ListenerSvc
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env}.json", true, true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            var host = config["RabbitMQ:Host"];
            var queue = config["RabbitMQ:Queue"];

            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                sbc.Host(host);
                sbc.ReceiveEndpoint(queue, e =>
                {
                    e.Consumer<NewsletterSubscriptionConsumer>();
                });
            });

            await bus.StartAsync();
            Console.WriteLine("-------------------\nListenerSvc running\n-------------------\nPress any key to exit...\n\n");
            await Task.Run(() => Console.ReadKey());
        }
    }
}
