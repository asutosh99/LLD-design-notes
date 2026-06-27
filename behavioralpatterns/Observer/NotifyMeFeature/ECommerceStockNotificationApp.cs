namespace BehavioralPatterns.Observer.NotifyMeFeature;

public class ECommerceStockNotificationApp
{
    public static void Run()
    {
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("###### E-commerce Store - Stock Availability Notification Feature Demo ######");

        IStockAvailabilityObservable iphoneProduct = new IphoneProductObservable("ip15", "iphone 15", 1250, 10);

        IStockNotificationObserver johnPush = new PushNotificationObserver("John123", "JohnDeviceP1");
        IStockNotificationObserver katyPush = new PushNotificationObserver("Katy678", "KatyDeviceP2");
        IStockNotificationObserver janeEmail = new EmailNotificationObserver("Jane783", "jane783@gmail.com");
        IStockNotificationObserver georgeEmail = new EmailNotificationObserver("George993", "george993@gmail.com");

        iphoneProduct.Purchase(10);

        bool success = iphoneProduct.Purchase(1);
        if (!success)
        {
            iphoneProduct.AddStockObserver(johnPush);
            iphoneProduct.AddStockObserver(katyPush);
            iphoneProduct.AddStockObserver(janeEmail);
            iphoneProduct.AddStockObserver(georgeEmail);
        }

        iphoneProduct.Restock(20);

        iphoneProduct.Purchase(1);
        iphoneProduct.Purchase(1);

        iphoneProduct.RemoveStockObserver(johnPush);
        iphoneProduct.RemoveStockObserver(katyPush);

        iphoneProduct.Purchase(18);
        iphoneProduct.Restock(5);

        iphoneProduct.Purchase(1);
        iphoneProduct.Purchase(1);

        iphoneProduct.RemoveStockObserver(janeEmail);
        iphoneProduct.RemoveStockObserver(georgeEmail);
    }
}
