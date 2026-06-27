namespace BehavioralPatterns.Visitor.Solution;

public class StandardRoom : IRoom
{
    private readonly string _roomNumber;

    public StandardRoom(string roomNumber)
    {
        _roomNumber = roomNumber;
    }

    public void Accept(IRoomVisitor visitor)
    {
        visitor.VisitStandardRoom(this);
    }

    public string GetRoomNumber() => _roomNumber;
}
