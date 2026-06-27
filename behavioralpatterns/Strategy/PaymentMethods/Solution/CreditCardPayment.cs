namespace BehavioralPatterns.Strategy.PaymentMethods.Solution;

public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        _cardNumber = cardNumber;
    }

    public void Pay(double amount)
    {
        Console.WriteLine("Paid $" + amount + " using credit card ending in "
                + _cardNumber.Substring(_cardNumber.Length - 4));
    }
}
