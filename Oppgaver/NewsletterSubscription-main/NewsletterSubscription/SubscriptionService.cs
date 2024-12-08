using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Implementations;
using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Interfaces;
using Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Model;

namespace Oppgaver.NewsletterSubscription_main.NewsletterSubscription
{
    internal class SubscriptionService
    {
        private readonly IEmailService _emailService;
        private ISubscriptionRepository _subscriptionRepository;

        public SubscriptionService(
            IEmailService emailService, 
            ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
            _emailService = emailService;
        }

        public void Subscribe(string emailAddress)
        {
            var subscription = new Subscription(emailAddress);
            _subscriptionRepository.Save(subscription);
            string subject = "Bekreft din abonnement";
            string text = $"Hei, vennligst bruk denne koden for å verifisere e-posten din: {subscription.VerificationCode}";
            var email = new Email("no-reply@newsletter.com", emailAddress, subject, text);
            _emailService.Send(email);
        }
        

        private void CheckEmailExist(Subscription subscription, string emailAddress)
        {
            if (subscription.Email == emailAddress)
            {
                throw new Exception($"Email {emailAddress} already exists");
            }
        }

        public void Verify(string emailAddress, string verificationCode)
        {
            var subscription = _subscriptionRepository.Load(emailAddress);
            CheckEmailExist(subscription, emailAddress);
            if (subscription.VerificationCode != verificationCode)
            {
                Console.WriteLine("Verification Code passer ikke din abonnement");
                return;
            }
            else
            {
                subscription.IsVerified = true;
                _subscriptionRepository.Save(subscription);
                Console.WriteLine(subscription.Email + "Verified");
            }

        }
    }
}
