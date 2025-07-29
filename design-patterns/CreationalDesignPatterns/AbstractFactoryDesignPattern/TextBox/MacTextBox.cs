using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.TextBox
{
    internal class MacTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Mac TextBox");
        }
    }
}
