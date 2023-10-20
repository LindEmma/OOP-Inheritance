using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

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
        }
        //constructor with 5 parameters
        public Canine(string fur,string colour, string gender, string name, int age, string sound)
            :base(colour,gender,name,age,sound)
        {
            _fur = fur;
        }
        //method that is inherited by all canines (dog and wolf)
        public void WagTail()
        {
            Console.WriteLine($"{_name} is happy and wags its tail!");
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
        }

        
    }
}
