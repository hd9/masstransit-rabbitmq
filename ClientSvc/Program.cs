using Core;
using Core.Events;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace ClientSvc
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = "rabbitmq://localhost";

            var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(host));
            });

            await bus.StartAsync();

            while (true)
            {
                Console.Write("\nEnter a name: ");
                var name = Console.ReadLine();
                
                Console.Write("Enter an email: ");
                var email = Console.ReadLine();

                await bus.Publish(new NewsletterSubscription { Name = name, Email = email });
            }

        }
    }
}
