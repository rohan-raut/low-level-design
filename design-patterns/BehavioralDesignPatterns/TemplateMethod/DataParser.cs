using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class DataParser
    {
        // Template Method defines the steps of an algorithm
        public void Parse()
        {
            OpenFile();
            ParseData();
            CloseFile();
        }

        public void OpenFile()
        {
            Console.WriteLine("File Opened");
        }

        public void CloseFile()
        {
            Console.WriteLine("File Closed");
        }

        public abstract void ParseData();
    }
}
