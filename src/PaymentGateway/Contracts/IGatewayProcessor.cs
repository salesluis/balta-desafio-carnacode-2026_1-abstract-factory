namespace DesignPatternChallenge;

public interface IGatewayProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}