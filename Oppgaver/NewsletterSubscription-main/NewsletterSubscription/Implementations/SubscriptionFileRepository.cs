﻿using System.Text.Json;
using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Interfaces;
using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Model;

namespace Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Implementations
{
    internal class SubscriptionFileRepository : ISubscriptionRepository
    {
        public void Save(Subscription subscription)
        {
            var json = JsonSerializer.Serialize(subscription);
            var filename = subscription.Email + ".json";
            File.WriteAllText(filename, json);
        }

        public Subscription Load(string email)
        {
            var filename = email + ".json";
            var json = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<Subscription>(json);
        }
        
    }
}
