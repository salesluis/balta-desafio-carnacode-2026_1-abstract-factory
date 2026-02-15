namespace DesignPatternChallenge;

public interface IGatewayValidator
{
    bool ValidateCard(string cardNumber);
}