namespace DesignPatternChallenge.Services.MercadoPago;

public class MercadoPagoLogger : IGatewayLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}