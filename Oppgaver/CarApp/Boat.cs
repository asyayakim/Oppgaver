namespace Oppgaver.CarApp;

public class Boat : Vehicles, IVehicles
{
    public Boat(string registrationNumber, string kw, string speed, string color, string type) : base(registrationNumber, kw, speed, color, type)
    {
    }

    public override string PrintVehicles()
    {
        return $"Boat - {RegistrationNumber}, {Kw}, {Speed}, {Color}, {Type}";
    }
}