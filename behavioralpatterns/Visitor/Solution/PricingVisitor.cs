namespace BehavioralPatterns.Visitor.Solution;

public class PricingVisitor : IRoomVisitor
{
    private double _totalRevenue;

    public void VisitStandardRoom(StandardRoom room)
    {
        double price = 1000.0;
        _totalRevenue += price;
        Console.WriteLine("Pricing: Standard room " + room.GetRoomNumber() +
                " - Rs." + price + "/night");
    }

    public void VisitDeluxeRoom(DeluxeRoom room)
    {
        double price = 2000.0;
        _totalRevenue += price;
        Console.WriteLine("Pricing: Deluxe room " + room.GetRoomNumber() +
                " - Rs." + price + "/night");
    }

    public void VisitSuiteRoom(SuiteRoom room)
    {
        double price = 5000.0;
        _totalRevenue += price;
        Console.WriteLine("Pricing: Suite " + room.GetRoomNumber() +
                " - Rs." + price + "/night");
    }

    public double GetTotalRevenue() => _totalRevenue;
}
