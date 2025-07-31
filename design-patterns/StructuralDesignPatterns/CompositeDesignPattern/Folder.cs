using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    internal class Folder : FileSystemComponent
    {
        private string folderName;
        private List<FileSystemComponent> components;

        public Folder(string _folderName)
        {
            folderName = _folderName;
            components = new List<FileSystemComponent>();
        }

        public void AddComponent(FileSystemComponent component)
        {
            components.Add(component);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Folder Name: {folderName}");
            foreach(FileSystemComponent component in components)
            {
                component.ShowDetails();
            }
        }
    }
}
