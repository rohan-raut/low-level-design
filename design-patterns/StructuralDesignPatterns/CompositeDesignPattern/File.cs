using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    internal class File : FileSystemComponent
    {
        private string filename;

        public File(string _filename)
        {
            filename = _filename;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"File Name: {filename}");
        }
    }
}
