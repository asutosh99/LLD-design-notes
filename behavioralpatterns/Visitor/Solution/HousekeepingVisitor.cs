namespace BehavioralPatterns.Visitor.Solution;

public class HousekeepingVisitor : IRoomVisitor
{
    public void VisitStandardRoom(StandardRoom room)
    {
        Console.WriteLine("Housekeeping: Cleaning standard room " +
                room.GetRoomNumber() + " (30 minutes)");
    }

    public void VisitDeluxeRoom(DeluxeRoom room)
    {
        Console.WriteLine("Housekeeping: Cleaning deluxe room " +
                room.GetRoomNumber() +
                (room.HasJacuzzi() ? " including jacuzzi" : "") +
                " (45 minutes)");
    }

    public void VisitSuiteRoom(SuiteRoom room)
    {
        Console.WriteLine("Housekeeping: Cleaning suite " +
                room.GetRoomNumber() + " with " +
                room.GetNumberOfRooms() + " rooms (90 minutes)");
    }
}
