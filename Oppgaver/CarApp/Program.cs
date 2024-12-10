namespace Oppgaver.CarApp;

public class Program
{
    static void Main(string[] args)
    {
        List<Vehicles> vehiclesList = new List<Vehicles>
        {
            new Cars("NF123456", "147kw", "200km/t", "green", "lett kjøretøy"),
            new Cars("NF654321", "150kw", "195km/t", "blue", "lett kjøretøy"),
            new Plain("LN1234", "1000kw", "30m", "2tonn", "10tonn", "jetfly")
        };
        foreach (var transport in vehiclesList)
        {
            Console.WriteLine(transport.PrintVehicles());
            transport.Fly();
        }

        vehiclesList[0].Drive();

        Cars.AreCarsTheSame(vehiclesList);
    }
}