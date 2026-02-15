namespace DesignPatternChallenge.PaymentGateway.Stripe;

public class StripeLogger : IGatewayLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}