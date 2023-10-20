//Emma Lind, Edugrade, .NET23

namespace ZooAnimalHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Objects of different animals.
            The Canine, Bird and Reptile classes inherits from the Animal class
            and in turn have two classes each inheriting them. 
            Only the last inheriting classes can be instantiated, the rest are abstract. 
         
            For example: you can not make an object of a bird, only penguin or Eagle. But they both inherit 
            methods and properties from the Bird class. */

            Dog dog = new Dog("long", "black and white", "female", "Mymlan", 5, "wuff", "Chihuahua");
            Eagle eagle = new Eagle("white", "male", "Örne", 4, "squiiiiii", "Bald eagle", true);
            Penguin penguin = new Penguin("black and white", "female", "Pingvinis", 7, "kwa kwa", false, "Emperor penguin");
            Wolf wolf = new Wolf("Siberia", "long", "grey", "male", "Vargis", 10, "aoooooooouuuu", "grey wolf");
            Snake snake = new Snake("green", "female", "Noodle", 12, "tsssss tssss", true, "Opheodrys");
            Tortoise tortoise = new Tortoise("brown", "male", "Tortimer", 199, "weee wee", "Galapagos");

            //All methods for each animal object
            Console.WriteLine("Welcome to the zoo!\n");
            Console.WriteLine("Canines:\n");
            wolf.PrintInfo();
            wolf.MakeSound();
            wolf.WolfHunt();
            wolf.WagTail();
            wolf.TellAnimalHealth();
            dog.PrintInfo();
            dog.MakeSound();
            dog.WagTail();
            dog.PlayCatch();
            dog.TellAnimalHealth();

            Console.WriteLine("Birds:\n");
            eagle.PrintInfo();
            eagle.MakeSound();
            eagle.Fly();
            eagle.EagleHunt();
            eagle.TellAnimalHealth();
            penguin.PrintInfo();
            penguin.MakeSound();
            penguin.Dive();
            penguin.Fly();
            penguin.TellAnimalHealth();

            Console.WriteLine("Reptiles:\n");
            snake.PrintInfo();
            snake.MakeSound();
            snake.Bite();
            snake.SunBathe();
            snake.TellAnimalHealth();
            tortoise.PrintInfo();
            tortoise.MakeSound();
            tortoise.Hide();
            tortoise.SunBathe();
            tortoise.TellAnimalHealth();
        }
    }
}