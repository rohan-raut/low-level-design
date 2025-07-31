namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemComponent file1 = new File("file1.txt");
            FileSystemComponent file2 = new File("file2.txt");
            FileSystemComponent file3 = new File("file3.txt");

            Folder rootFolder = new Folder("root");
            Folder subFolder = new Folder("subFolder");

            rootFolder.AddComponent(file1);
            rootFolder.AddComponent(file2);
            rootFolder.AddComponent(subFolder);
            subFolder.AddComponent(file3);

            rootFolder.ShowDetails();
        }
    }
}

/*
 * Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they 
 * were individual objects.
 * 
 * Problem: When building systems like file directory, which consists of both individual items (files) and groups of items (directories), 
 * managing these with standard object hierarchies can become complex.
 * 
 * Solution: The composite pattern allows you to treat individual objects and compositions of objects uniformly by representing part-whole hierarchies.
 * 
 */
