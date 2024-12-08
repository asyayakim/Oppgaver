using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Model;

namespace Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Interfaces
{
    internal interface ISubscriptionRepository
    {
        void Save(Subscription subscription);
        Subscription Load(string email);
    }
}
