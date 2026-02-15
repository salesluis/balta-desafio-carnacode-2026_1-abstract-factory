namespace DesignPatternChallenge.PaymentGateway.PagSeguro;

public partial class PagSeguroValidator : IGatewayValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}