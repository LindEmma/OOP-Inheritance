namespace ZooAnimalHandler
{
    public abstract class Canine : Animal
    {
        protected string Fur { get; set; }

        //default constructor
        public Canine()
        {
            Fur = "unknown";
            Gender = "unknown";
            Colour = "unknown";
            Name = "unknown";
            Age = 0;
            Sound = "gnyl";
            SpeciesOrBreed = "?";
        }
        //constructor with 5 parameters
        public Canine(string fur, string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(colour, gender, name, age, sound, speciesOrBreed)
        {
            Fur = fur;
        }
        //method that is inherited by all canines (dog and wolf)
        public void WagTail()
        {
            Console.WriteLine($"{Name} is happy and wags its tail!\n");
        }
    }
}
