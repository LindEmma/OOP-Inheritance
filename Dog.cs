namespace ZooAnimalHandler
{
    //sub class Dog, inherits from class Animal
    public class Dog : Canine
    {
        protected string _breed { get; set; }

        //default constructor
        public Dog()
        {
            _breed = "?";
            _fur = "unknown";
            _gender = "unknown";
            _colour = "unknown";
            _name = "unknown";
            _age = 0;
            _sound = "Wuff wuff";
        }

        public Dog(string fur, string colour, string breed, string gender, string name, int age, string sound)
            : base(fur, colour, gender, name, age, sound) //Animal constructor is inherited??
        {
            _breed = breed;
        }

        public void PlayCatch() //fixa
        {
            Console.WriteLine($"Do you want to throw {_name} a ball? (yes/no)");

            string answer = Console.ReadLine();

            while (answer != "no")
            {
                switch (answer)
                {
                    case "yes":
                        if (_gender.ToLower() == "female")
                        {
                            Console.WriteLine($"{_name} caught the ball you just threw! Good girl!");
                        }
                        else if (_gender.ToLower() == "male")
                        {
                            Console.WriteLine($"{_name} caught the ball you just threw! Good boy!");
                        }
                        else
                        {
                            Console.WriteLine($"{_name} caught the ball you just threw! Good dog!");
                        }
                        break;
                    case "no":
                        Console.WriteLine($"{_name} looks at you with big sad eyes and slowly walks away...");
                        break;

                    default:
                        Console.WriteLine("Please answer yes or no");
                        answer = Console.ReadLine();
                        break;
                }
            }
        }
        public override void TellAnimalHealth()
        {
            Random random = new Random();
            int x = random.Next(0, 2);

            if (x == 0)
            {
                Console.WriteLine($"{_name} is healthy!");
            }
            else if (x == 1)

            {
                Console.WriteLine($"{_name} has the dog flu and needs medication!");

            }
            Console.WriteLine();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog info:\nBreed: {_breed}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\nFur length: {_fur}");
            Console.WriteLine();
        }
    }
}

//Hierarchial inheritance. När flera klasser ärver från samma

//single inheritance: när en klass ärver från en annan

//Multiple inheritance: när en klass ärver från flera (interface)

//Multilevel inheritance: när en klass ärver från en annan derived klass. (viktig labb 6)
//Class A{}, Class B:A{}, class C:B{} osv. Klass C ärver fält och metoder från både A och B.

//