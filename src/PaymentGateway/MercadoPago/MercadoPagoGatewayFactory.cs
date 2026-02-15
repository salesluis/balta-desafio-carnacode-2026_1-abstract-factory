using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Services.MercadoPago;

namespace DesignPatternChallenge.PaymentGateway.MercadoPago;

public class MercadoPagoGatewayFactory : IPaymentGatewayFactory
{
    public IGatewayValidator CreateValidator()
        => new MercadoPagoValidator();

    public IGatewayProcessor CreateProcessTransaction()
        => new MercadoPagoProcessor();

    public IGatewayLogger CreateLog()
        => new MercadoPagoLogger();
}