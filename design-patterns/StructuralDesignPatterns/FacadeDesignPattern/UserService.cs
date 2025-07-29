using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class UserService
    {
        public string GetUserDetails(string userId)
        {
            return $"User details for userId: {userId}";
        }
    }
}
