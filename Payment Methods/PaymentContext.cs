using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal class PaymentContext
    {
        private IPaymentMethod? _paymentMethod;
        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void ExecutePayment(decimal amount)
        {
            if (_paymentMethod != null)
            {
                _paymentMethod.ProcessPayment(amount);
            }
            else
            {
                Console.WriteLine("payment method not set");
            }
        }
    }
}
