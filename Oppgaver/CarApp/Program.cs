namespace Oppgaver.CarApp;

public class Program
{
    static void Main(string[] args)
    {
        List<Cars> vehiclesList = new List<Cars>
        {
            new Cars("NF123456", "147kw", "200km/t", "green", "lett kjøretøy"),
            new Cars("NF654321", "150kw", "195km/t", "blue", "lett kjøretøy"),
            //new Plain("LN1234", "1000kw", "30m", "2", "jetfly" )
        };
        foreach (var car in vehiclesList)
        {
            Console.WriteLine(car.RegistrationNumber + " " + car.Kw + " " + car.Speed + " " + car.Color);
            Cars.AreCarsTheSame(vehiclesList);
        }
        
    }

    
}

