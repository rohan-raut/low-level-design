namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListCollection listCollection = new ListCollection();
            ListIterator? iterator = listCollection.CreateIterator() as ListIterator;

            if (iterator == null)
            {
                return;
            }

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext().ToString());
            }
        }
    }
}

/*
 * 
 * Reference video: https://www.youtube.com/watch?v=X7shKHOaYtU
 * 
 * Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation 
 * (list, stack, tree, etc.).
 * 
 * ListIterator follows composition and when the collection is destroyed the Iterator should also get destroyed.
 * 
 */
