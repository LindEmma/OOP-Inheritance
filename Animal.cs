using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    //abstract base class Animal
    public abstract class Animal
    {
        //Field variables 
        protected string _gender { get; set; }
        protected string _colour { get; set; }
        protected string _name { get; set; }
        protected int _age { get; set; }
        protected string _sound { get; set; }
        protected string _speciesOrBreed { get; set; }

        //default constructor
        public Animal()
        {
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "?";
            _speciesOrBreed = "?";
        }
        //Instance constructor with 6 parameters
        public Animal(string colour,string gender,string name, int age, string sound,string speciesOrBreed)
        {
            _gender = gender;
            _colour = colour;
            _name = name;
            _age = age;
            _sound = sound;
            _speciesOrBreed = speciesOrBreed;
        }
        //method with if-statement that tells if animal is sick and needs medication. Same for all inheriting classes. 
        public void TellAnimalHealth()
        {
            Random random = new Random();
            int x = random.Next(0, 2);

            if (x == 0)
            {
                Console.WriteLine($"{_name} is healthy!");
            }
            else if (x == 1)

            {
                Console.WriteLine($"{_name} is sick and needs medication!");
            }
            Console.WriteLine();
        }
        //abstract method that prints the animals info, needs to be overrided in inheriting classes. 
        public abstract void PrintInfo();

        //method that is accessible in all classes. Same for each class.
        public void MakeSound()
        {
            Console.WriteLine($"{_name} says *{_sound}*\n");
        }

    }
}
