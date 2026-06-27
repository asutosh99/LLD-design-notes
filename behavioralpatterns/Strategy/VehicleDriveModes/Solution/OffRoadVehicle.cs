namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class OffRoadVehicle : Vehicle
{
    public OffRoadVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
    {
    }
}
