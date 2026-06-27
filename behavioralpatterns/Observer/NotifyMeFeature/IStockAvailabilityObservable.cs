namespace BehavioralPatterns.Observer.NotifyMeFeature;

public interface IStockAvailabilityObservable
{
    void AddStockObserver(IStockNotificationObserver observer);
    void RemoveStockObserver(IStockNotificationObserver observer);
    void NotifyStockObservers();
    bool Purchase(int quantity);
    void Restock(int quantity);
}
