namespace BehavioralPatterns.Visitor.Problem;

public class Demo
{
    public static void Run()
    {
        Console.WriteLine("##### Visitor Pattern: Problem Demo #####");
        SuiteHotelRoom suite = new SuiteHotelRoom("301", "2");
        suite.Clean();
        suite.DeliverRoomService("Breakfast");
        suite.CalculatePrice();
    }
}
