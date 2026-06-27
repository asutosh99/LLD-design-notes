namespace BehavioralPatterns.ChainOfResponsibility;

public class InfoLogProcessor : LogProcessor
{
    public InfoLogProcessor(int level)
    {
        Level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("INFO: " + message);
    }
}
