namespace BehavioralPatterns.Observer.NotifyMeFeature;

public class EmailNotificationObserver : IStockNotificationObserver
{
    private readonly string _userId;
    private readonly string _emailAddress;

    public EmailNotificationObserver(string userId, string emailAddress)
    {
        _userId = userId;
        _emailAddress = emailAddress;
    }

    public void Update()
    {
        SendEmail();
    }

    private void SendEmail()
    {
        Console.WriteLine("!! EMAIL SENT to: " + _emailAddress + " - " + "Product is back in stock! Hurry Up!!");
    }

    public string GetNotificationMethod() => "Email";
    public string GetUserId() => _userId;
}
