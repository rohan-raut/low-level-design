using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class BoldCommand : ICommand
    {
        private TextEditor _editor;

        public BoldCommand(TextEditor editor)
        {
            _editor = editor;
        }

        public void Execute()
        {
            _editor.BoldText();
        }
    }
}
