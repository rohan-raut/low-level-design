using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class ItalicText : ICommand
    {
        private TextEditor _editor;

        public ItalicText(TextEditor editor)
        {
            _editor = editor;
        }

        public void Execute()
        {
            _editor.ItalicText();
        }
    }
}
