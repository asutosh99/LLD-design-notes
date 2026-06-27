namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class EVDrive : IDriveStrategy
{
    public void Drive()
    {
        Console.WriteLine("Driving Capability: Electric");
    }
}
