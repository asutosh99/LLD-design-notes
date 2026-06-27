namespace BehavioralPatterns.Observer.NotifyMeFeature;

public class PushNotificationObserver : IStockNotificationObserver
{
    private readonly string _userId;
    private readonly string _deviceToken;

    public PushNotificationObserver(string userId, string deviceToken)
    {
        _userId = userId;
        _deviceToken = deviceToken;
    }

    public void Update()
    {
        SendPushNotification();
    }

    private void SendPushNotification()
    {
        Console.WriteLine("!! PUSH NOTIFICATION SENT to: " + _deviceToken + " - " + "Product is back in stock! Hurry Up!!");
    }

    public string GetNotificationMethod() => "Push Notification";
    public string GetUserId() => _userId;
}
