using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class ProxyImage : IImage
    {
        private string filename;
        private RealImage realImage = null;

        public ProxyImage(string _filename)
        {
            filename = _filename;
        }
        
        public void Display()
        {
            if(realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }
}
