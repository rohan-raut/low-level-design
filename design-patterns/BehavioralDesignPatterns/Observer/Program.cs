namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppleStore store = new AppleStore();

            Subscriber user1 = new Subscriber();
            user1.userId = 1;

            Subscriber user2 = new Subscriber();
            user2.userId = 2;

            Subscriber user3 = new Subscriber();
            user3.userId = 3;

            store.AddSubscriber(user1);
            store.AddSubscriber(user2);
            store.AddSubscriber(user3);

            store.Notify();

            Console.WriteLine("-----------------------");

            store.RemoveSubscriber(user2);

            store.Notify();
        }
    }
}
