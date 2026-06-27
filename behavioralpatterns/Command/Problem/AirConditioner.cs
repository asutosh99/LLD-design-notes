namespace BehavioralPatterns.Command.Problem;

public class AirConditioner
{
    public bool IsOn;
    public int Temperature;

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Air conditioner is on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Air conditioner is off");
    }

    public void SetTemperature(int temperature)
    {
        Temperature = temperature;
        Console.WriteLine("Air conditioner temperature set to " + temperature);
    }
}
