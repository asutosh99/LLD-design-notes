namespace BehavioralPatterns.Visitor.Solution;

public class DeluxeRoom : IRoom
{
    private readonly string _roomNumber;
    private readonly bool _hasJacuzzi;

    public DeluxeRoom(string roomNumber, bool hasJacuzzi)
    {
        _roomNumber = roomNumber;
        _hasJacuzzi = hasJacuzzi;
    }

    public void Accept(IRoomVisitor visitor)
    {
        visitor.VisitDeluxeRoom(this);
    }

    public string GetRoomNumber() => _roomNumber;
    public bool HasJacuzzi() => _hasJacuzzi;
}
