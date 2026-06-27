namespace BehavioralPatterns.Strategy.PaymentMethods.Problem;

public class PaymentProcessor
{
    public void ProcessPayment(string type, double amount)
    {
        switch (type)
        {
            case "credit_card":
                Console.WriteLine("Paid $" + amount + " using credit card");
                break;
            case "paypal":
                Console.WriteLine("Paid $" + amount + " using PayPal");
                break;
            case "net_banking":
                Console.WriteLine("Paid $" + amount + " using bank transfer");
                break;
            case "cash":
                Console.WriteLine("Paid $" + amount + " using cash");
                break;
            default:
                throw new InvalidOperationException("Unexpected value: " + type);
        }
    }
}
