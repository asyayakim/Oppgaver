namespace Oppgaver.NewsletterSubscription_main.NewsletterSubscription.Model
{
    internal class Subscription
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string VerificationCode { get; set; }
        public bool IsVerified { get; set; }

        public Subscription(string email)
        {
            Name = "Default Name";
            Email = email;
            VerificationCode = Guid.NewGuid().ToString();
            IsVerified = false;
        }

        public override string ToString()
        {
            return $"Navn: {Name}, E-post: {Email}, Verifisert: {IsVerified}, Kode: {VerificationCode}";
        }
    }
}
