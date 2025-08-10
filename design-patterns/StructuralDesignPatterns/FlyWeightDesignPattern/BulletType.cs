using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    internal class BulletType
    {
        private string color;

        public BulletType(string _color)
        {
            color = _color;
            Console.WriteLine("Creating BulletType with color: " + color);
        }
    }
}
