namespace ZooAnimalHandler
{
    public abstract class Bird : Animal
    {
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
        }

        //Constructor with 6 parameters
        public Bird(string colour, string gender, string name, int age, string sound, Boolean canFly)
            : base(colour, gender, name, age, sound)
        {
            _canFly = canFly;
        }
        //method that is unique to animals inheriting from the bird class
        public void Fly()
        {
            if (_canFly == true)
            {
                Console.WriteLine($"{_name} takes a leap off a cliff and fly away in the horizon... it's majestic!");
            }
            else
            {
                Console.WriteLine($"{_name} takes a leap off a cliff and... falls flat on the ground.\nYikes.\n");
            }
            Console.WriteLine();
        }
        public override void TellAnimalHealth()
        {
            Random random = new Random();
            int x = random.Next(0, 2);

            if (x == 0)
            {
                Console.WriteLine($"{_name} is healthy!");

            }
            else
            {
                Console.WriteLine($"{_name} has the bird flu and needs medication!");

            }
            Console.WriteLine();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Bird info:\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\nAbility to fly:{_canFly}");
            Console.WriteLine();
        }

       
    }
}
