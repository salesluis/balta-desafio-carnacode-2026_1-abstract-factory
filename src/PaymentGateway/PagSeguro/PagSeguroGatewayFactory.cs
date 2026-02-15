using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.PaymentGateway.PagSeguro;

public class PagSeguroGatewayFactory : IPaymentGatewayFactory
{
    public IGatewayValidator CreateValidator()
        => new PagSeguroValidator();

    public IGatewayProcessor CreateProcessTransaction()
        => new PagSeguroProcessor();

    public IGatewayLogger CreateLog()
        => new PagSeguroLogger();
}