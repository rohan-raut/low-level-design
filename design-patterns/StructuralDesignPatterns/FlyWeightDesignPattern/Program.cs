namespace FlyWeightDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 Red bullets
            for(int i=0; i<5; i++)
            {
                Bullet bullet = new Bullet(i * 10, i * 5, i * 15, "Red");
                bullet.Display();
            }

            // 5 Green bullets
            for (int i = 0; i < 5; i++)
            {
                Bullet bullet = new Bullet(i * 10, i * 5, i * 15, "Green");
                bullet.Display();
            }
        }
    }
}

/*
 * In game development, especially in scenarios like shooting games where numerous identical bullets are fired, memory and performance can quickly 
 * become an issue if each bullet object stores redundant data. Using the Flyweight Pattern, we can reduce memory overhead by sharing intrinsic 
 * properties of bullets (like appearance) while maintaining unique extrinsic properties (like position and velocity).
 * 
 * Problem: Creating many identical or similar objects in memory-heavy applications can lead to excessive memory consumption.
 * 
 * Solution: By sharing the common state among multiple objects (the flyweights), the pattern reduces the memory footprint.
 * 
 * Intrinsic Property: Properties which do not change.
 * Extrinsic Property: Properties which have different states.
 * 
 */
