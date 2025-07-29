using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class XMLDataAnalyzer : IDataAnalyzer
    {
        public void AnalyzeData(string data)
        {
            Console.WriteLine("Analyzing XML Data");
        }
    }
}
