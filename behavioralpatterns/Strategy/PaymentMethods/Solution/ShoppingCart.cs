namespace BehavioralPatterns.Strategy.PaymentMethods.Solution;

public class ShoppingCart
{
    private IPaymentStrategy? _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _paymentStrategy = strategy;
    }

    public void Checkout(double amount)
    {
        Console.Write(_paymentStrategy!.GetType().Name + ": ");
        _paymentStrategy.Pay(amount);
    }
}
