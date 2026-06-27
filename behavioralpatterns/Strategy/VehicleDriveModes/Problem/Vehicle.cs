namespace BehavioralPatterns.Strategy.VehicleDriveModes.Problem;

public class Vehicle
{
    public virtual void Drive()
    {
        Console.Write("\n" + GetType().Name + ": ");
        Console.WriteLine("Driving Capability: Normal");
    }
}
