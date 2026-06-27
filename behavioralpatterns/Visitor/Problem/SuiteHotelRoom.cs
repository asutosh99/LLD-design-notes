namespace BehavioralPatterns.Visitor.Problem;

public class SuiteHotelRoom
{
    private readonly string _roomNumber;
    private readonly string _numberOfRooms;

    public SuiteHotelRoom(string roomNumber, string numberOfRooms)
    {
        _roomNumber = roomNumber;
        _numberOfRooms = numberOfRooms;
    }

    public void Clean()
    {
        Console.WriteLine("Housekeeping: Cleaning suite " +
                _roomNumber + " with " +
                _numberOfRooms + " rooms (90 minutes)");
    }

    public void DeliverRoomService(string orderDetails)
    {
        Console.WriteLine("Room Service: VIP delivery of " + orderDetails +
                " to suite " + _roomNumber +
                " with full dining setup");
    }

    public double CalculatePrice()
    {
        Console.WriteLine("Pricing: Suite " + _roomNumber +
                " - Rs. 2000/night");
        return 500.0;
    }
}
