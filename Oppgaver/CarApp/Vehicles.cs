namespace Oppgaver.CarApp
{
    internal class Cars(string RegistrationNumber, string kw, string speed, string color, string type)
    {
        public string RegistrationNumber { get; }
        public string Kw { get; }
        public string Speed { get; }
        public string Color { get; }
        public string Type { get; }

        public static void AreCarsTheSame(List<Cars> vehiclesList)
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
    }
    
   
}