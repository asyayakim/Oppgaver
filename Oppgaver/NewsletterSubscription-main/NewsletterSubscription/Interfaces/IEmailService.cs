using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Model;

namespace Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Interfaces
{
    public interface IEmailService
    {
        void Send(Email email);
    }
}