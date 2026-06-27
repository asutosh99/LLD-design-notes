namespace BehavioralPatterns.Strategy.PaymentMethods.Solution;

public interface IPaymentStrategy
{
    void Pay(double amount);
}
