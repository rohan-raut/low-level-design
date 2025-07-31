using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class OliveDecorator : PizzaDecorator
    {
        public OliveDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", Olive";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 0.60;
        }
    }
}
