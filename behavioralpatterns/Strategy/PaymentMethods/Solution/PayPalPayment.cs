namespace BehavioralPatterns.Strategy.PaymentMethods.Solution;

public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPayment(string email)
    {
        _email = email;
    }

    public void Pay(double amount)
    {
        Console.WriteLine("Paid $" + amount + " using PayPal account " + _email);
    }
}
