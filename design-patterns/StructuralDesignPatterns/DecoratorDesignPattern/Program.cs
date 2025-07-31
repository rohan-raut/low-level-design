namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new BasicPizza();

            pizza = new CheeseDecorator(pizza);
            pizza = new OliveDecorator(pizza);
            pizza = new MushroomDecorator(pizza);

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
        }
    }
}

/*
 * When you need to add functionality to an object at runtime, but subclassing would lead to an explosion of subclasses or is impractical.
 * (BasicPizza, CheesePizza, CheeseOlivePizza, OlivePizza, OliveMushroomPizza, CheeseMushroomPizza, .....) -> class explosion.
 * Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects 
 * that contain the behaviors.
 * 
 * Let's say we have a simple Pizza ordering system. Initially, we just have plain pizza but now we want to add options such as cheese, olives, 
 * tomatoes and mushrooms without modifying the existing pizza class or creating multiple subclasses.
 * 
 * Let's use the Decorator Pattern using a Pizza making example where different toppings (like cheese, olives, tomatoes, etcc.) can be 
 * dynamically added to the base pizza.
 * 
 */
