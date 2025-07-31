using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class AppleStore : IPublisher
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.UpdateMe("We launched new iPhone 16");
            }
        }
    }
}
