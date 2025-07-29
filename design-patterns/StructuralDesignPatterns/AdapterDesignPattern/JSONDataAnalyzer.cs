using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    // this is a 3rd party library for analyzing data which is much cheaper.
    internal class JSONDataAnalyzer
    {
        public void AnalyzeJSONData(string jsonData)
        {
            Console.WriteLine("Analyzing JSON Data");
        }
    }
}
