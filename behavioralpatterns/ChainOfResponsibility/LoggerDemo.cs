namespace BehavioralPatterns.ChainOfResponsibility;

public class LoggerDemo
{
    public static void Run()
    {
        Console.WriteLine("###### Chain of Responsibility Design Pattern ######");

        LogProcessor logProcessor = GetChainOfLoggers();

        Console.WriteLine("Logging messages:");
        Console.WriteLine("===== Logging DEBUG message =====");
        logProcessor.LogMessage(LogProcessor.Debug, "This is a debug message");
        Console.WriteLine("===== Logging INFO message =====");
        logProcessor.LogMessage(LogProcessor.Info, "This is an info message");
        Console.WriteLine("===== Logging ERROR message =====");
        logProcessor.LogMessage(LogProcessor.Error, "This is an error message");
        Console.WriteLine("===== Logging FATAL message =====");
        logProcessor.LogMessage(LogProcessor.Fatal, "This is a fatal message");
    }

    private static LogProcessor GetChainOfLoggers()
    {
        LogProcessor fatalLogger = new FatalLogProcessor(LogProcessor.Fatal);
        LogProcessor errorLogger = new ErrorLogProcessor(LogProcessor.Error);
        LogProcessor infoLogger = new InfoLogProcessor(LogProcessor.Info);
        LogProcessor debugLogger = new DebugLogProcessor(LogProcessor.Debug);

        debugLogger.SetNextLogger(infoLogger);
        infoLogger.SetNextLogger(errorLogger);
        errorLogger.SetNextLogger(fatalLogger);

        return debugLogger;
    }
}
