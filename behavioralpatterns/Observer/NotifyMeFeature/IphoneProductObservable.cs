namespace BehavioralPatterns.Observer.NotifyMeFeature;

public class IphoneProductObservable : IStockAvailabilityObservable
{
    private readonly string _productId;
    private readonly string _productName;
    private readonly double _price;
    private readonly List<IStockNotificationObserver> _stockObservers = new();
    private int _stockQuantity;

    public IphoneProductObservable(string productId, string productName, double price, int stockQuantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _stockQuantity = stockQuantity;
    }

    public void AddStockObserver(IStockNotificationObserver observer)
    {
        _stockObservers.Add(observer);
        Console.WriteLine("[+]" + observer.GetUserId() + " subscribed for notifications on " + _productName);
    }

    public void RemoveStockObserver(IStockNotificationObserver observer)
    {
        _stockObservers.Remove(observer);
        Console.WriteLine("[-]" + observer.GetUserId() + " unsubscribed for notifications on " + _productName);
    }

    public void NotifyStockObservers()
    {
        if (_stockQuantity > 0 && _stockObservers.Count > 0)
        {
            Console.WriteLine("Notifying " + _stockObservers.Count + " subscribers... ");

            var observersToNotify = new List<IStockNotificationObserver>(_stockObservers);

            foreach (var observer in observersToNotify)
            {
                observer.Update();
            }
        }
    }

    public void Restock(int quantity)
    {
        bool wasOutOfStock = (_stockQuantity == 0);
        _stockQuantity += quantity;
        Console.WriteLine("RESTOCKED: " + _productName + " - Added " + quantity + " items " + " | " + "Current stock: " + _stockQuantity);

        if (wasOutOfStock && _stockQuantity > 0)
        {
            NotifyStockObservers();
        }
    }

    public bool Purchase(int quantity)
    {
        if (_stockQuantity >= quantity)
        {
            _stockQuantity -= quantity;
            Console.WriteLine("PURCHASE SUCCESS: " + quantity + " units of " + _productName + " | " + "Remaining stock: " + _stockQuantity);
            return true;
        }
        else
        {
            Console.WriteLine("PURCHASE FAILED: " + _productName + " is out of stock! | " + "Available Quantity: " + _stockQuantity);
            return false;
        }
    }

    public string GetProductId() => _productId;
    public string GetProductName() => _productName;
    public double GetPrice() => _price;
    public int GetStockQuantity() => _stockQuantity;
}
