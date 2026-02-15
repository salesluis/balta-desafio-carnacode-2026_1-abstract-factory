namespace DesignPatternChallenge.PaymentGateway.MercadoPago;

public partial class MercadoPagoValidator : IGatewayValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Mercado Pago: Validando cartão...");
        return cardNumber.Length == 16;
    }
}