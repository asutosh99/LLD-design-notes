namespace BehavioralPatterns.Visitor.Solution;

public class RoomServiceVisitor : IRoomVisitor
{
    private readonly string _orderDetails;

    public RoomServiceVisitor(string orderDetails)
    {
        _orderDetails = orderDetails;
    }

    public void VisitStandardRoom(StandardRoom room)
    {
        Console.WriteLine("Room Service: Delivering " + _orderDetails +
                " to standard room " + room.GetRoomNumber());
    }

    public void VisitDeluxeRoom(DeluxeRoom room)
    {
        Console.WriteLine("Room Service: Premium delivery of " + _orderDetails +
                " to deluxe room " + room.GetRoomNumber() +
                " with complimentary champagne");
    }

    public void VisitSuiteRoom(SuiteRoom room)
    {
        Console.WriteLine("Room Service: VIP delivery of " + _orderDetails +
                " to suite " + room.GetRoomNumber() +
                " with full dining setup");
    }
}
