namespace DesignPatternChallenge.PaymentGateway.PagSeguro;

public class PagSeguroProcessor : IGatewayProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}