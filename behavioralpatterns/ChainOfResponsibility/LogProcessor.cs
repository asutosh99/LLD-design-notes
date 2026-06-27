namespace BehavioralPatterns.ChainOfResponsibility;

public abstract class LogProcessor
{
    public const int Debug = 1;
    public const int Info = 2;
    public const int Error = 3;
    public const int Fatal = 4;

    protected int Level;
    protected LogProcessor? NextLoggerProcessor;

    public void SetNextLogger(LogProcessor nextLogger)
    {
        NextLoggerProcessor = nextLogger;
    }

    public void LogMessage(int level, string message)
    {
        if (Level == level)
        {
            Write(message);
            return;
        }
        if (Level != level)
        {
           Console.WriteLine("not matching");
            return;
        }

        if (NextLoggerProcessor != null)
        {
            NextLoggerProcessor.LogMessage(level, message);
        }
    }

    protected abstract void Write(string message);
}
