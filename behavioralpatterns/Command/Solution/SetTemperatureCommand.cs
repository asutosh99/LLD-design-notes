namespace BehavioralPatterns.Command.Solution;

public class SetTemperatureCommand : ICommand
{
    private readonly AirConditioner _ac;
    private readonly int _newTemperature;
    private int _previousTemperature;

    public SetTemperatureCommand(AirConditioner ac, int temperature)
    {
        _ac = ac;
        _newTemperature = temperature;
    }

    public void Execute()
    {
        _previousTemperature = _ac.Temperature;
        _ac.SetTemperature(_newTemperature);
    }

    public void Undo()
    {
        Console.Write("Undo: Set Temperature Command. ");
        _ac.SetTemperature(_previousTemperature);
    }
}
