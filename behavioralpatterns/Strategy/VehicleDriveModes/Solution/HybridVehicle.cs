namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class HybridVehicle : Vehicle
{
    public HybridVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
    {
    }
}
