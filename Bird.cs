namespace ZooAnimalHandler
{
    public abstract class Bird : Animal
    {
        //field variable, unique for Bird.
        protected bool CanFly { get; set; }

        //default constructor
        public Bird()
        {
            CanFly = false;
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "chirp chirp";
            SpeciesOrBreed = "?";
        }
        //Constructor that also inherits from Animal class with base-keyword
        public Bird(string colour, string gender, string name, int age, string sound, bool canFly, string speciesOrBreed)
            : base(colour, gender, name, age, sound,speciesOrBreed)
        {
            CanFly = canFly;
        }
        //method that is unique to animals inheriting from the bird class
        public void Fly()
        {
            if (CanFly == true)
            {
                Console.WriteLine($"{Name} takes a leap off a cliff and flies away over the horizon... it's majestic!");
            }
            else
            {
                Console.WriteLine($"{Name} takes a leap off a cliff and... falls flat on the ground.\nYikes.");
            }
            Console.WriteLine();
        }

        // This only makes the method accessible for the classes inheriting this one
        public override void PrintInfo()
        {
        }

       
    }
}
