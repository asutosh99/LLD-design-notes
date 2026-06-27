namespace BehavioralPatterns.Strategy.VehicleDriveModes.Problem;

public class OffRoadVehicle : Vehicle
{
    public override void Drive()
    {
        Console.Write("\n" + GetType().Name + ": ");
        Console.WriteLine("Driving Capability: Sports");
    }
}
