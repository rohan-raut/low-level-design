using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    internal class Subscriber : ISubscriber
    {
        public int userId { get; set; }

        public void UpdateMe(string message)
        {
            Console.WriteLine($"{userId}: {message}");
        }
    }
}
