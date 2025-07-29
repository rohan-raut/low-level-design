using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal interface IDataAnalyzer
    {
        void AnalyzeData(string data);
    }
}
