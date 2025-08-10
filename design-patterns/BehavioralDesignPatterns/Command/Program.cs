namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            Button button = new Button();

            button.SetCommand(new BoldCommand(editor));
            button.click();

            button.SetCommand(new ItalicText(editor));
            button.click();
        }
    }
}

/*
 * 
 * Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This 
 * transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.
 * 
 * When to use?
 * - Decoupling of Invoker and Receiver: The button (invoker) doesn't  know the details of the TextEditor(receiver), making the system more flexible 
 * and reusable.
 * - Command History and Undo: Commands can be logged for undo/redo functionality.
 * - Task Queuing: Commands can be stored in a queue and executed later, making it useful for task scheduling.
 * - Extensibility: New commands can be added easily without modifying existing code. For example, adding a ChangeColorCommand only requires 
 * creating a new command class.
 * 
 */
