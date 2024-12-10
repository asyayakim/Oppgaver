namespace Oppgaver.CarApp
{
    public class Vehicles : IVehicles
    {
        private string _registrationNumber;

        public Vehicles(string registrationNumber, string kw, string speed, string color, string type)
        {
            RegistrationNumber = registrationNumber;
            Kw = kw;
            Speed = speed;
            Color = color;
            Type = type;
        }

        public string RegistrationNumber { get; }
        public string Kw { get; }
        public string Speed { get; }
        public string Color { get; }
        public string Type { get; }

        public virtual string PrintVehicles()
        {
            return $"Vehicle - {RegistrationNumber}, {Kw}, {Speed}, {Color}, {Type}";
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flying vehicle");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving vehicle");
        }
    }
    
}

