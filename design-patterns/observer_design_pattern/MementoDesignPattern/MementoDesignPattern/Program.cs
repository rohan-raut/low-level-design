using MementoDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        CareTaker careTaker = new CareTaker(editor);

        editor.SetState("Hello World");
        careTaker.SaveState();

        editor.SetState("Hello Rohan");
        careTaker.SaveState();

        careTaker.RestoreState();

        editor.display();
    }
}

/*
 * Why we don't store the TextEditor directly in history list instead of storing Memento objects.
 * - We don't want the careTaker entity to have access to SetState or modity any data. We just give the necessary methods to access of TextEditor to careTaker acheiving encapsulation.
 *
 * 
 * | Component      | Responsibility                                                          |
 * | -------------- | ----------------------------------------------------------------------- |
 * | **Originator** | Creates and restores its own state                                      |
 * | **Memento**    | Stores the state of the Originator (internal state snapshot)            |
 * | **Caretaker**  | **Stores and manages Mementos**, but **does not access their contents** |
 *
 * 
 */