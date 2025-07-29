using CommandDesignPattern;

class Program
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