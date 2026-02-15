// DESAFIO: Sistema de Pagamentos Multi-Gateway
// PROBLEMA: Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento
// (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger)
// O código atual está muito acoplado e dificulta a adição de novos gateways

using DesignPatternChallenge.PaymentGateway.MercadoPago;
using DesignPatternChallenge.PaymentGateway.PagSeguro;
using DesignPatternChallenge.PaymentGateway.Stripe;

namespace DesignPatternChallenge
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Pagamentos ===\n");
        
        Console.WriteLine();
        var stripeFactory = new StripeGatewayFactory(); 
        var stripeService = new Services.PaymentGatewayService(stripeFactory);
        stripeService.ProcessPayment(150.00m, "1234567890123456");
        
        Console.WriteLine();
        var mercadoLivreFactory = new MercadoPagoGatewayFactory();
        var mercadoLivreService = new Services.PaymentGatewayService(mercadoLivreFactory);
        mercadoLivreService.ProcessPayment(150.00m, "1234567890123456");
        
        Console.WriteLine();
        var pagSeguroFactory = new PagSeguroGatewayFactory();
        var pagSeguroService = new Services.PaymentGatewayService(pagSeguroFactory);
        pagSeguroService.ProcessPayment(150.00m, "123453456");

        Console.WriteLine();
        
    }
}
}
