using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    internal class Bullet
    {
        private int x, y;
        private int velocity;
        private BulletType bulletType;

        public Bullet(int x, int y,  int velocity, string color)
        {
            this.x = x;
            this.y = y;
            this.velocity = velocity;
            bulletType = BulletTypeFactory.getBulletType(color);
        }

        public void Display()
        {
            Console.WriteLine("Bullet at (" + x + ", " + y + ") moving at velocity " + velocity);
        }
    }
}
