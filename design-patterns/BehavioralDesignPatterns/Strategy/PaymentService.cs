using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PaymentService
    {
        private IPaymentMethod strategy;

        public void SetStrategy(IPaymentMethod paymentMethod)
        {
            this.strategy = paymentMethod;
        }

        public void Pay()
        {
            strategy.ProcessPayment();
        }
    }
}
