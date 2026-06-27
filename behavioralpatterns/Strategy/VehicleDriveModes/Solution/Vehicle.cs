namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class Vehicle
{
    private readonly IDriveStrategy _driveStrategy;

    public Vehicle(IDriveStrategy driveStrategy)
    {
        _driveStrategy = driveStrategy;
    }

    public void Drive()
    {
        Console.Write("\n" + GetType().Name + ": ");
        _driveStrategy.Drive();
    }
}
