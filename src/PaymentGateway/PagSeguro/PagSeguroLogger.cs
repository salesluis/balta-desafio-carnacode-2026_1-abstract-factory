namespace DesignPatternChallenge.PaymentGateway.PagSeguro;

public class PagSeguroLogger : IGatewayLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}