using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    internal interface IPublisher
    {
        public void AddSubscriber(Subscriber subscriber);

        public void RemoveSubscriber(Subscriber subscriber);

        public void Notify();
    }
}
