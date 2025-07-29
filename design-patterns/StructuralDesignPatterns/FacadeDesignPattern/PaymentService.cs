using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class PaymentService
    {
        public string ProcessPayment(string paymentId)
        {
            return $"Processing payment with paymentId: {paymentId}";
        }
    }
}
