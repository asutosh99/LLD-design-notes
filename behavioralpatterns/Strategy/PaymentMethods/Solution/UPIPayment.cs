namespace BehavioralPatterns.Strategy.PaymentMethods.Solution;

public class UPIPayment : IPaymentStrategy
{
    private readonly string _upiId;

    public UPIPayment(string upiId)
    {
        _upiId = upiId;
    }

    public void Pay(double amount)
    {
        Console.WriteLine("Paid $" + amount + " using UPI ID " + _upiId);
    }
}
