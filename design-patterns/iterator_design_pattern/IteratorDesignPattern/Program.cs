using IteratorDesignPattern;

class Program
{
    /* 
     
    Reference video: https://www.youtube.com/watch?v=X7shKHOaYtU

    ListIterator follows composition and when the collection is destroyed the Iterator should also get destroyed.
     
     */
    static void Main(string[] args)
    {
        ListCollection listCollection = new ListCollection();
        ListIterator? iterator = listCollection.CreateIterator() as ListIterator;

        if(iterator == null)
        {
            return;
        }

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.GetNext().ToString());
        }
    }
}