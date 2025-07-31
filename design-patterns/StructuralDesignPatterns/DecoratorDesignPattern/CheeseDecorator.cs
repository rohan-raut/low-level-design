using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", Cheese";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 1.00;
        }
    }
}
