namespace BehavioralPatterns.Strategy.VehicleDriveModes.Solution;

public class Demo
{
    public static void Run()
    {
        Console.WriteLine("###### Strategy Design Pattern ######");
        Console.WriteLine("###### Example: Vehicle Drive Modes ######");

        Vehicle vehicle = new SportsVehicle(new SportsDrive());
        vehicle.Drive();

        vehicle = new GoodsVehicle(new NormalDrive());
        vehicle.Drive();

        vehicle = new HybridVehicle(new EVDrive());
        vehicle.Drive();

        vehicle = new GoodsVehicle(new NormalDrive());
        vehicle.Drive();
    }
}
