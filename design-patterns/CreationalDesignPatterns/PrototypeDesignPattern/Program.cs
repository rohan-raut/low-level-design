namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassC obj = new ClassC(100, 25.4f, "Rohan");
            Console.WriteLine(obj.ToString());

            ClassC cloneObj = obj.Clone() as ClassC;
            cloneObj.name = "Swapnil";
            Console.WriteLine(cloneObj.ToString());
        }
    }
}

/*
 * Prototype Design pattern is used when you want a copy of the objects to manipulate or need to store some set of configuration which are required
 * frequently so that we can just clone them and use it.
 * 
 * During Cloning we need to understand how we want to copy an object, Shallow copying or Deep copying.
 * In Shallow copying, we just copy the reference to the main object.
 * In Deep copying, we actually create new object using 'new' keyword and then copy data inside that.
 * 
 * Which copying method should be used totally depends on the user usecase.
 * 
 * Another Example: https://refactoring.guru/design-patterns/prototype/csharp/example
 * 
 */
