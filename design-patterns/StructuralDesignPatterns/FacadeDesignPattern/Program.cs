namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client code interacting with APIGateway which is acting as facade.
            APIGateway gateway = new APIGateway();
            string details = gateway.getFullOrderDetails("111", "OR736", "9823928");
            Console.WriteLine(details);
        }
    }
}

/*
 * In software engineering, a common real-world example of the Facade Pattern is an API Gateway in a microservices architecture.
 * 
 * Problem without Facade:
 * In a microservice architecture, each microservice can have its own API for specific business logic, such as user management, order processing, 
 * and inventory. If the client needs to interact with these microservices, it would need to directly communicate with the individual services. 
 * This would increase the complexity of the client code, thightly couplt the client to all the microservices, and expose the inner workings of 
 * the system.
 * 
 * Solution Using Facade (API Gateway):
 * The API Gateway acts as a facade, providing a unified interface to the client while handling communication with the underlying microservices. 
 * It simplifies client interactions, reduces network calls, and abstracts away the complexity of dealing with multiple services.
 */
