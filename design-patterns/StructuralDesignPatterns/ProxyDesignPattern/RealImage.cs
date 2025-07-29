using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class RealImage : IImage
    {
        private string filename;

        public RealImage(string _filename)
        {
            filename = _filename;
            LoadImage(); // this is an expensive operation.
        }

        public void Display()
        {
            Console.WriteLine("Displaying the image...");
        }

        public void LoadImage()
        {
            Console.WriteLine("Loading Image....");
        }

    }
}
