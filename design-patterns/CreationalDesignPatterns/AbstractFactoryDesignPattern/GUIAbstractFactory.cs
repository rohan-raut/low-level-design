using AbstractFactoryDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class GUIAbstractFactory
    {
        public static IFactory? CreateFactory(string OSType)
        {
            IFactory? factory = null;

            if(OSType == "Win")
            {
                factory = new WinFactory();
            }
            else if(OSType == "Mac")
            {
                factory = new MacFactory();
            }

            return factory;
        }
    }
}
