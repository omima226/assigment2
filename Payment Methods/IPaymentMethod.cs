﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }
}
