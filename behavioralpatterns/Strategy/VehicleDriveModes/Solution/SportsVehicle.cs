namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class SportsVehicle : Vehicle
{
    public SportsVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
    {
    }
}
