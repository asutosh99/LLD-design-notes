namespace BehavioralPatterns.Command.Solution;

public class AirConditioner
{
    public bool IsOn { get; set; }
    public int Temperature { get; set; }

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
        Console.WriteLine("Air conditioner temperature set to " + temperature + "°C");
    }
}
