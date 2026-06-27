namespace BehavioralPatterns.Command.Solution;

public class RemoteController
{
    private ICommand? _command;
    private readonly Stack<ICommand> _commandHistory = new();

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command!.Execute();
        _commandHistory.Push(_command);
    }

    public void Undo()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
    }
}
