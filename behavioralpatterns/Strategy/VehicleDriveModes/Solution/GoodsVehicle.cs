namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class GoodsVehicle : Vehicle
{
    public GoodsVehicle(IDriveStrategy driveStrategy) : base(driveStrategy)
    {
    }
}
