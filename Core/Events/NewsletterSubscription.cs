using System;

namespace Core.Events
{
    public class NewsletterSubscription
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn => DateTime.UtcNow;

        public override string ToString() => $"[NewsletterSubscription] \"{Name}\" <{Email}>";
    }
}
