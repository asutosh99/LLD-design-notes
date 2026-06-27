namespace BehavioralPatterns.Visitor.Solution;

public interface IRoomVisitor
{
    void VisitStandardRoom(StandardRoom room);
    void VisitDeluxeRoom(DeluxeRoom room);
    void VisitSuiteRoom(SuiteRoom room);
}
