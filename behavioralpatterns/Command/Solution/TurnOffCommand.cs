namespace BehavioralPatterns.Command.Solution;

public class TurnOffCommand : ICommand
{
    private readonly AirConditioner _ac;
    private bool _previousState;

    public TurnOffCommand(AirConditioner ac)
    {
        _ac = ac;
    }

    public void Execute()
    {
        _previousState = _ac.IsOn;
        _ac.TurnOff();
    }

    public void Undo()
    {
        Console.Write("Undo: Turn Off command. ");
        if (_previousState)
        {
            _ac.TurnOn();
        }
    }
}
