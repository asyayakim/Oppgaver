using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Interfaces;
using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Model;

namespace Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Implementations
{
    public class DummyEmailService : IEmailService
    {
        public void Send(Email email)
        {
            Console.WriteLine($"Sending email to: {email.To}, Subject: {email.Subject}, Text: {email.Text}");
        }
    }

}
