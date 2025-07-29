using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Button
{
    internal class WinButton : IButton
    {
        public void OnPress()
        {
            Console.WriteLine("Windows button pressed");
        }
    }
}
