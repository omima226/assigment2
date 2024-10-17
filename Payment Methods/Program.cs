namespace Payment_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentContext paymentContext = new PaymentContext();
            Console.WriteLine("Choose a payment method (1: Credit Card , 2: Bank Transfer, 3: PayPal): ");
            string choice = Console.ReadLine();
            IPaymentMethod paymentMethod = choice switch
            {
                "1" => new CreditCardPayment(),
                "2" => new BankTransfer(),
                "3" => new PayPal(), 
                _ => throw new ArgumentException("payment method is invalid")
            };
            paymentContext.SetPaymentMethod(paymentMethod);
            Console.WriteLine("Enter amount to pay");
            decimal amount = decimal.Parse(Console.ReadLine());
            paymentContext.ExecutePayment(amount);
        }
    }
}
