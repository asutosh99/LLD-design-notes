namespace BehavioralPatterns.Visitor.Solution;

public class HotelVisitorDemo
{
    public static void Run()
    {
        Console.WriteLine("\n###### Visitor Design Pattern Demo ######");

        IRoom[] rooms = {
            new StandardRoom("101"),
            new DeluxeRoom("201", true),
            new SuiteRoom("301", 3),
            new StandardRoom("102"),
            new DeluxeRoom("202", false)
        };

        Console.WriteLine("\n==> Housekeeping Service");
        IRoomVisitor housekeeping = new HousekeepingVisitor();
        foreach (var room in rooms)
        {
            room.Accept(housekeeping);
        }

        Console.WriteLine("\n==> Room Service");
        IRoomVisitor roomService = new RoomServiceVisitor("Breakfast");
        rooms[0].Accept(roomService);
        rooms[1].Accept(roomService);
        rooms[2].Accept(roomService);

        Console.WriteLine("\n==> Revenue Calculation");
        PricingVisitor pricing = new PricingVisitor();
        foreach (var room in rooms)
        {
            room.Accept(pricing);
        }
        Console.WriteLine("Total Revenue: Rs." + pricing.GetTotalRevenue());
    }
}
