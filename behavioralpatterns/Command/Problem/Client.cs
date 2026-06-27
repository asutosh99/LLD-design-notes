namespace BehavioralPatterns.Command.Problem;

public class Client
{
    public static void Run()
    {
        Console.WriteLine("##### Command Pattern: Problem Demo #####");

        AirConditioner airConditioner = new AirConditioner();
        airConditioner.TurnOn();
        airConditioner.SetTemperature(25);
        airConditioner.TurnOff();

        Bulb bulb = new Bulb();
        bulb.TurnOn();
        bulb.TurnOff();
    }
}
