using AbstractFactoryDesignPattern.Button;
using AbstractFactoryDesignPattern.TextBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory
{
    internal class WinFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox();
        }
    }
}
