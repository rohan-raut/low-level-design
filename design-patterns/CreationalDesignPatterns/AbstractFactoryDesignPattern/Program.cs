using AbstractFactoryDesignPattern.Button;
using AbstractFactoryDesignPattern.Factory;
using AbstractFactoryDesignPattern.TextBox;

namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the OS Type: ");
            string? OSType = Console.ReadLine();

            IFactory? factory = GUIAbstractFactory.CreateFactory(OSType);

            if(factory != null )
            {
                IButton button = factory.CreateButton();
                button.OnPress();

                ITextBox textBox = factory.CreateTextBox();
                textBox.Display();
            }
        }
    }
}

/*
 * People start with Factory Design pattern then start shifting to Abstract Factory as products increases.
 * Abstract Factory is used when we have a family of products which should match the same theme.
 * 
 */
