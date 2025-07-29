using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    internal class CSVParser : DataParser
    {
        public override void ParseData()
        {
            Console.WriteLine("Parsing CSV data");
        }
    }
}
