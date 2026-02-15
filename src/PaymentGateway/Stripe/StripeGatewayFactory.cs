using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Services.MercadoPago;

namespace DesignPatternChallenge.PaymentGateway.Stripe;

public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public IGatewayValidator CreateValidator()
        => new StripeValidator();

    public IGatewayProcessor CreateProcessTransaction()
        => new StripeProcessor();

    public IGatewayLogger CreateLog()
        => new StripeLogger();
}