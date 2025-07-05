using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    internal class CareTaker
    {
        private List<Memento> history = new List<Memento>();

        private TextEditor editor;

        public CareTaker(TextEditor pEditor)
        {
            this.editor = pEditor;
        }

        public void SaveState()
        {
            history.Add(editor.SaveState());
        }

        public void RestoreState()
        {
            if(history.Count > 0)
            {
                history.RemoveAt(history.Count - 1);
                editor.Undo(history[history.Count - 1]);
            }
        }
    }
}
