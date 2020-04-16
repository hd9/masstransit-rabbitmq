using Core;
using Core.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListenerSvc.Consumers
{
    public class NewsletterSubscriptionConsumer : IConsumer<NewsletterSubscription>
    {
        public async Task Consume(ConsumeContext<NewsletterSubscription> context)
        {
            await Console.Out.WriteLineAsync(context.Message.ToString());

            // todo :: do your stuff
        }
    }
}
