using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    internal interface ISubscriber
    {
        public void UpdateMe(string message);
    }
}
