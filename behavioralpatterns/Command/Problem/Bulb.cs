namespace BehavioralPatterns.Command.Problem;

public class Bulb
{
    public bool IsOn;

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Bulb is on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Bulb is off");
    }
}
