using AbstractFactoryDesignPattern.Button;
using AbstractFactoryDesignPattern.TextBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Factory
{
    internal interface IFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
