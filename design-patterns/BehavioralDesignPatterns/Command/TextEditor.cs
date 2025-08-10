using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class TextEditor
    {
        public void BoldText()
        {
            Console.WriteLine("Text has been bolded.");
        }

        public void ItalicText()
        {
            Console.WriteLine("Test has been Italic.");
        }

        public void UnderlineText()
        {
            Console.WriteLine("Text has been underlined.");
        }
    }
}
