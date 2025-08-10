using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class CreditCard : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment via credit card.....");
        }
    }
}
