namespace BehavioralPatterns.ChainOfResponsibility;

public class ErrorLogProcessor : LogProcessor
{
    public ErrorLogProcessor(int level)
    {
        Level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("ERROR: " + message);
    }
}
