using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal interface IPizza
    {
        string GetDescription();

        double GetCost();
    }
}
