namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class NormalDrive : IDriveStrategy
{
    public void Drive()
    {
        Console.WriteLine("Driving Capability: Normal");
    }
}
