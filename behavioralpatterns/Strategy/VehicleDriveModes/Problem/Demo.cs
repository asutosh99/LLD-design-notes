namespace BehavioralPatterns.Strategy.VehicleDriveModes.Problem;

public class Demo
{
    public static void Run()
    {
        Console.WriteLine("Vehicle Drive Modes: Problem Demo");
        Vehicle vehicle = new SportsVehicle();
        vehicle.Drive();

        vehicle = new OffRoadVehicle();
        vehicle.Drive();

        vehicle = new PassengerVehicle();
        vehicle.Drive();
    }
}
