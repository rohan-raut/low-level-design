using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", Mushroom";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 0.50;
        }
    }
}
