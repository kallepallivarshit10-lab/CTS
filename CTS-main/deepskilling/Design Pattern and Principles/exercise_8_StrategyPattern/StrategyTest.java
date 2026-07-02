public class StrategyTest {

    public static void main(String[] args) {

        // Credit Card Payment
        PaymentContext context =
                new PaymentContext(
                        new CreditCardPayment());

        context.executePayment(5000);

        // PayPal Payment
        context =
                new PaymentContext(
                        new PayPalPayment());

        context.executePayment(10000);

    }
}
