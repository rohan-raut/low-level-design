namespace SingletonDesignPattern
{
    internal class Program
    {

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        static void Main(string[] args)
        {
            Thread process1 = new Thread(() =>
            {
                TestSingleton("Foo");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("Bar");
            });

            
            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }
    }
}

/*
 * Singleton Pattern is used when we just want single instance of object throughout the application. Eg. Logger, DBConnection
 * 
 * Reference: https://refactoring.guru/design-patterns/singleton/csharp/example
 * 
 */
