namespace Oppgaver.CarApp
{
    public class Plain : Vehicles, IVehicles
    {
        public Plain(string registrationNumber, string kw, string speed, string color,string weight, string type) : base(
            registrationNumber, kw, speed, color, type)
        {
            Weight = weight;
        }

        public string Weight { get; }

        public override string PrintVehicles()
        {
            return $"Plane - {RegistrationNumber}, {Kw}, {Speed}, {Color},{Weight}, {Type}";
        }


        public override void Fly()
        {
            Console.WriteLine($"Flyight with RegistrationNumber {RegistrationNumber} is flying!"); 
        }

        public override void Drive()
        {
            return;
        }
    }
}

