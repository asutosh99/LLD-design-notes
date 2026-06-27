namespace BehavioralPatterns.Command.Solution;

public class Client
{
    public static void Run()
    {
        Console.WriteLine("##### Command Pattern: Solution Demo #####");

        AirConditioner airConditioner = new AirConditioner();
        RemoteController remoteObj = new RemoteController();

        remoteObj.SetCommand(new TurnOnCommand(airConditioner));
        remoteObj.PressButton();
        remoteObj.SetCommand(new SetTemperatureCommand(airConditioner, 25));
        remoteObj.PressButton();
        remoteObj.SetCommand(new SetTemperatureCommand(airConditioner, 18));
        remoteObj.PressButton();
        remoteObj.SetCommand(new TurnOffCommand(airConditioner));
        remoteObj.PressButton();

        remoteObj.Undo();
        remoteObj.Undo();
        remoteObj.Undo();
        remoteObj.Undo();
    }
}
