using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    internal class TextEditor
    {
        private string state;

        public void SetState(string data)
        {
            state = data;
        }

        public Memento SaveState()
        {
            return new Memento(state);
        }

        public void Undo(Memento memento)
        {
            state = memento.getState();
        }

        public void display()
        {
            Console.WriteLine(state);
        }
    }
}
