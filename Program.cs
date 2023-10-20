namespace ZooAnimalHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Mymlan = new Dog("long", "black and white", "chihuahua", "female", "Mymlan", 5, "wuff");
            Eagle eagle = new Eagle("white", "male", "Fåglis", 4, "squieeeeee",true);
            Penguin penguin = new Penguin("black and white", "female", "Pingvinis", 7, "kwa kwa", false, "Emperor penguin");
            Wolf wolf = new Wolf();
            wolf.PrintInfo();
            
            eagle.PrintInfo();
            eagle.Fly();
            eagle.TellAnimalHealth();
            eagle.MakeSound();
            penguin.PrintInfo();
            penguin.MakeSound();
            penguin.TellAnimalHealth();
            penguin.Dive();
            penguin.Fly();
            Mymlan.PrintInfo();
            Mymlan.TellAnimalHealth();
            Mymlan.MakeSound();
            Mymlan.PlayCatch();
        }
    }
}