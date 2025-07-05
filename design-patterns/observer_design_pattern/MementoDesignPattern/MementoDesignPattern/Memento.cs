using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    internal class Memento : IMemento
    {
        private string state;
        private DateTime date;

        public Memento(string data)
        {
            state = data;
            date = DateTime.Now;
        }

        public DateTime getDate()
        {
            return date;
        }

        public string getState()
        {
            return state;
        }
    }
}
