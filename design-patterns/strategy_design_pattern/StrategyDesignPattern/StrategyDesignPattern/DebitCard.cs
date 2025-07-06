using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class DebitCard : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment via Debit card.....");
        }
    }
}
