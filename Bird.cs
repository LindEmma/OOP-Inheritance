namespace ZooAnimalHandler
{
    public abstract class Bird : Animal
    {
        //field variable, unique for Bird.
        protected Boolean _canFly { get; set; }

        //default constructor
        public Bird()
        {
            _canFly = false;
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "chirp chirp";
            _speciesOrBreed = "?";
        }
        //Constructor that also inherits from Animal class with base-keyword
        public Bird(string colour, string gender, string name, int age, string sound, Boolean canFly, string speciesOrBreed)
            : base(colour, gender, name, age, sound,speciesOrBreed)
        {
            _canFly = canFly;
        }
        //method that is unique to animals inheriting from the bird class
        public void Fly()
        {
            if (_canFly == true)
            {
                Console.WriteLine($"{_name} takes a leap off a cliff and flies away over the horizon... it's majestic!");
            }
            else
            {
                Console.WriteLine($"{_name} takes a leap off a cliff and... falls flat on the ground.\nYikes.");
            }
            Console.WriteLine();
        }

        // This only makes the method accessible for the classes inheriting this one
        public override void PrintInfo()
        {
        }

       
    }
}
