namespace BehavioralPatterns.Strategy.PaymentMethods.Problem;

public class Demo
{
    public static void Run()
    {
        Console.WriteLine("Payment Processor: Problem Demo");
        PaymentProcessor processor = new PaymentProcessor();
        processor.ProcessPayment("credit_card", 100);
        processor.ProcessPayment("paypal", 200);
        processor.ProcessPayment("net_banking", 300);
        processor.ProcessPayment("cash", 400);
    }
}
