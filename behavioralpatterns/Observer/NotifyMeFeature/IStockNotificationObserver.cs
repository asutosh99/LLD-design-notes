namespace BehavioralPatterns.Observer.NotifyMeFeature;

public interface IStockNotificationObserver
{
    void Update();
    string GetNotificationMethod();
    string GetUserId();
}
