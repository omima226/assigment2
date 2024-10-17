using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal class CreditCardPayment:IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"credit card payment: {amount:c} is prossed");
        }
    }
}
