namespace BehavioralPatterns.ChainOfResponsibility;

public class FatalLogProcessor : LogProcessor
{
    public FatalLogProcessor(int level)
    {
        Level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("FATAL: " + message);
    }
}
