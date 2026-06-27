namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class SportsDrive : IDriveStrategy
{
    public void Drive()
    {
        Console.WriteLine("Driving Capability: Sports");
    }
}
