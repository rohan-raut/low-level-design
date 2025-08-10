namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}

/*
 * When we want to add new funtionality or behavior to the existing objects, but we cannot directly add the methods in those object because it may violate 
 * the Single Responsibility Principle or we don't want the existing code to break because of the new changes as the code is already in production.
 * That time we can create a seperate class Visitor, which contains all the new functionality. There could be various methods in visitor class which can 
 * be called from the object based on its requirement.
 * Eg. Some objects wants to extract the data in XML format and some objects want to extract in JSON format.
 * Visitor will have two different methods for this.
 * 
 * And later if we want to add more new functionalities, we can have another visitor class for that.
 * 
 * - Use this pattern when you want to extend the functionalities but don't want to touch the existing classes core jobs.
 * 
 * 
 */
