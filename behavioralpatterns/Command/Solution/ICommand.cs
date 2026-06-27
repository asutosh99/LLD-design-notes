namespace BehavioralPatterns.Command.Solution;

public interface ICommand
{
    void Execute();
    void Undo();
}
