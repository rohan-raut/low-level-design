using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class APIGateway
    {
        private UserService userService;
        private OrderService orderService;
        private PaymentService paymentService;

        public APIGateway()
        {
            this.userService = new UserService();
            this.orderService = new OrderService();
            this.paymentService = new PaymentService();
        }

        public string getFullOrderDetails(string userId, string orderId, string paymentId)
        {
            return $"{userService.GetUserDetails(userId)} \n {orderService.GetOrderDetails(orderId)} \n {paymentService.ProcessPayment(paymentId)}";
        }
    }
}
