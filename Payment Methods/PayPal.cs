using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal class PayPal:IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"PayPal payment {amount:c} is prossed");
        }
    }
}
