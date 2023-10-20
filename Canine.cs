namespace ZooAnimalHandler
{
    public abstract class Canine : Animal
    {
        protected string _fur { get; set; }

        //default constructor
        public Canine()
        {
            _fur = "unknown";
            _gender = "unknown";
            _colour = "unknown";
            _name = "unknown";
            _age = 0;
            _sound = "gnyl";
            _speciesOrBreed = "?";
        }
        //constructor with 5 parameters
        public Canine(string fur, string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(colour, gender, name, age, sound,speciesOrBreed)
        {
            _fur = fur;
        }
        //method that is inherited by all canines (dog and wolf)
        public void WagTail()
        {
            Console.WriteLine($"{_name} is happy and wags its tail!\n");
        }
        public override void PrintInfo()
        {
        }
    }
}
