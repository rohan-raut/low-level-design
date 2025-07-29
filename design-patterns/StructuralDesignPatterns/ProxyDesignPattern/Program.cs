namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage img1 = new ProxyImage("dog.png");
            IImage img2 = new ProxyImage("cat.png");

            img1.Display(); // real image object creatation + Image Loading + Displaying (Lazy Loading)
            img1.Display(); // Displaying from cache

            // img2 is not used also is not loaded from disk which saves CPU time and memory.
        }
    }
}

/*
 * Why to use Prototype Pattern?
 * - Lazy Initialization: Objects are loaded only when necessary saving CPU time and memory.
 * - Access Control: You can control access to the real object (eg. based on user permission)
 * - Additional Behaviour: Proxies can add additional functionalities like logging, access control or caching without modifying the real object.
 * - Seperation of Concerns: The real object only deals with its core responsibilities, while the proxy handles all the main operations like 
 * initialization or security.
 */
