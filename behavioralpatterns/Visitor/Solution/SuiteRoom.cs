namespace BehavioralPatterns.Visitor.Solution;

public class SuiteRoom : IRoom
{
    private readonly string _roomNumber;
    private readonly int _numberOfRooms;

    public SuiteRoom(string roomNumber, int numberOfRooms)
    {
        _roomNumber = roomNumber;
        _numberOfRooms = numberOfRooms;
    }

    public void Accept(IRoomVisitor visitor)
    {
        visitor.VisitSuiteRoom(this);
    }

    public string GetRoomNumber() => _roomNumber;
    public int GetNumberOfRooms() => _numberOfRooms;
}
