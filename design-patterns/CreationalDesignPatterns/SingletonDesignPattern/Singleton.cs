using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Singleton
    {
        private static Singleton instance;
        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton GetInstance(string value)
        {
            // double check because the lock operation is costly
            if(instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                        instance.Value = value;
                    }
                }
            }
            
            return instance;
        }

        public string Value { get; set; }
    }
}
