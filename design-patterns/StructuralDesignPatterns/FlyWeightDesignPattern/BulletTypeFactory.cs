using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    internal class BulletTypeFactory
    {
        private static Dictionary<string, BulletType> bulletTypes = new Dictionary<string, BulletType>();

        public static BulletType getBulletType(string color)
        {
            if(bulletTypes.TryGetValue(color, out BulletType type) == false)
            {
                BulletType newBulletType = new BulletType(color);
                bulletTypes.Add(color, newBulletType);
            }

            return bulletTypes[color];

        }
    }
}
