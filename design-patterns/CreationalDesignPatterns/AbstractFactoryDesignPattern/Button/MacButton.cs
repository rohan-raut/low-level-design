using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Button
{
    internal class MacButton : IButton
    {
        public void OnPress()
        {
            Console.WriteLine("Mac Button pressed");
        }
    }
}
