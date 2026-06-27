namespace BehavioralPatterns.Command.Solution;

public class TurnOnCommand : ICommand
{
    private readonly AirConditioner _ac;
    private bool _previousState;

    public TurnOnCommand(AirConditioner ac)
    {
        _ac = ac;
    }

    public void Execute()
    {
        _previousState = _ac.IsOn;
        _ac.TurnOn();
    }

    public void Undo()
    {
        Console.Write("Undo: Turn On command. ");
        if (!_previousState)
        {
            _ac.TurnOff();
        }
    }
}
