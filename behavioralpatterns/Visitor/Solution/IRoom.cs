namespace BehavioralPatterns.Visitor.Solution;

public interface IRoom
{
    void Accept(IRoomVisitor visitor);
}
