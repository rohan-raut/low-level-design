using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual double GetCost()
        {
            return pizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return pizza.GetDescription();
        }
    }
}
