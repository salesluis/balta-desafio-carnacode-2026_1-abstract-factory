namespace DesignPatternChallenge.PaymentGateway.Stripe;

public class StripeValidator : IGatewayValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        return cardNumber.Length == 16;
    }
}