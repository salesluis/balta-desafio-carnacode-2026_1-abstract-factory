namespace DesignPatternChallenge.Contracts;

public interface IPaymentGatewayFactory
{
    
    IGatewayValidator CreateValidator();
    IGatewayProcessor CreateProcessTransaction();
    IGatewayLogger CreateLog();
}
