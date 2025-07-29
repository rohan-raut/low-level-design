namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IImplementation imp1 = new ConcreteImplementation1();
            IImplementation imp2 = new ConcreteImplementation2();

            Abstraction abstraction = new Abstraction(imp1);

            Console.WriteLine(abstraction.Operation());

            abstraction.ChangeImplementation(imp2);
            Console.WriteLine(abstraction.Operation());
        }
    }
}

/*
 * If there is a class which can have multiple implementation or different types of performing the same operation, then we tend to create many classes
 * with dedicated implementation.
 * Bridge pattern helps to decouple the implementation from the class and avoiding the repeatation of code. This pattern helps to achieve the 
 * Dependency Inversion Priciple by following the Dependency Injection.
 * 
 * Follow the example of Cage in SOLID Priciples folder.
 * 
 * In Bridge Pattern, we allow the client to pass there own required implementation to the class and here pass the reference of the implementation object
 * acts as a bridge.
 * 
 * Here, we can even inherit the Abstraction class and add new properties and methods to it (optional).
 * 
 */
