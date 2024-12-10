namespace Oppgaver.CarApp
{
    internal class Cars : Vehicles, IVehicles
    {

        public Cars(string registrationNumber, string kw, string speed, string color, string type) : base(registrationNumber, kw, speed, color, type)
        {
        }

        public override string PrintVehicles()
        {
            return $"Car - {RegistrationNumber}, {Kw}, {Speed}, {Color}, {Type}";
        }

        public static void AreCarsTheSame(List<Vehicles> vehiclesList)
        {
            if (vehiclesList.Count == 0)
            {
                return;
            }
            var car1 = vehiclesList[0];
            var car2 = vehiclesList[1];
            if (car1.RegistrationNumber != car2.RegistrationNumber
                || car1.Kw != car2.Kw ||
                car1.Speed != car2.Speed ||
                car1.Color != car2.Color
                || car1.Type != car2.Type)
            {
                Console.WriteLine("Cars are not the same");
            }

        }

        public override void Fly()
        {
            return;
        }

        public override void Drive()
        {
            Console.WriteLine($"Car with register number {RegistrationNumber} is driving now!");
        }
    }
    
   
}