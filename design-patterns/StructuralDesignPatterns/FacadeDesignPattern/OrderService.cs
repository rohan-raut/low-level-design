using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class OrderService
    {
        public string GetOrderDetails(string orderId)
        {
            return $"Order details for orderId: {orderId}";
        }
    }
}
