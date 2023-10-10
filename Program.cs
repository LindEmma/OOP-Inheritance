namespace ZooAnimalHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Dog","Mymlan", "female", 5, true, "long", "gny");
            dog1.TellGender();
            dog1.Catch();
            dog1.PrintDogInfo();

        }
    }
}