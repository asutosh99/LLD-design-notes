namespace BehavioralPatterns.Strategy.PaymentMethods.Solution;

public class Demo
{
    public static void Run()
    {
        Console.WriteLine("###### Strategy Design Pattern ######");
        Console.WriteLine("###### Example: Payment Processor ######");

        ShoppingCart cart = new ShoppingCart();

        cart.SetPaymentStrategy(new CreditCardPayment("1234-5678-9012-3456"));
        cart.Checkout(100.0);
        cart.SetPaymentStrategy(new PayPalPayment("johndoe@example.com"));
        cart.Checkout(200.0);
        cart.SetPaymentStrategy(new UPIPayment("9988776655@ybl"));
        cart.Checkout(300.0);
    }
}
