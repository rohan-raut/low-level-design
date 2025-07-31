using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class BasicPizza : IPizza
    {
        public double GetCost()
        {
            return 5.00;
        }

        public string GetDescription()
        {
            return "Basic Pizza";
        }
    }
}
