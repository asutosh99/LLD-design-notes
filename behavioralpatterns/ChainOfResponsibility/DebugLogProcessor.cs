namespace BehavioralPatterns.ChainOfResponsibility;

public class DebugLogProcessor : LogProcessor
{
    public DebugLogProcessor(int level)
    {
        Level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("DEBUG: " + message);
    }
}
