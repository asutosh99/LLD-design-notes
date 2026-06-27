namespace BehavioralPatterns.Strategy.VehicleDriveModes.Problem;

public class SportsVehicle : Vehicle
{
    public override void Drive()
    {
        Console.Write("\n" + GetType().Name + ": ");
        Console.WriteLine("Driving Capability: Sports");
    }
}
