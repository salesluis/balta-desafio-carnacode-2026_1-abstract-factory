using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Services;

public class PaymentGatewayService(IPaymentGatewayFactory factory)
{
    private readonly IPaymentGatewayFactory _paymentGatewayFactory = factory;

    public void ProcessPayment(Decimal value, string cardNumber)
    {
        var validator = _paymentGatewayFactory.CreateValidator();
        var cardIsValid = validator.ValidateCard(cardNumber);
        if (!cardIsValid)
        {
            Console.WriteLine("Mercado Pago: Cartão inválido");
            return;
        }
        var process = _paymentGatewayFactory.CreateProcessTransaction();
        var result = process.ProcessTransaction(value, cardNumber);
        
        var logger = _paymentGatewayFactory.CreateLog();
        logger.Log(result);
    }
    
}