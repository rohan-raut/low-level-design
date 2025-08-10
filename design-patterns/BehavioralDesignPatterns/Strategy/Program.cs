namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService();

            CreditCard creditCard = new CreditCard();
            DebitCard debitCard = new DebitCard();

            paymentService.SetStrategy(creditCard);
            paymentService.Pay();

            paymentService.SetStrategy(debitCard);
            paymentService.Pay();
        }
    }
}

/*
 * Let's consider a simple payment system where users can pay using different methods like credit cards or PayPal.
 * Without the strategy pattern, you might use if-else conditions to handle the different payment methods, leading to less maintainable and flexible code.
 * 
 * With stategy pattern, we can easily extend the strategies in future like UPI payment, PhonePe, etc without touching the code in PaymentService class.
 * 
 */
