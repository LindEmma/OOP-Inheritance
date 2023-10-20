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
        protected string _gender { get; set; }
        protected string _colour { get; set; }
        protected string _name { get; set; }
        protected int _age { get; set; }
        protected string _sound { get; set; }

        //default constructor
        public Animal()
        {
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "?";
        }

        //Instance constructor with 5 parameters
        public Animal(string colour,string gender,string name, int age, string sound)
        {
            _gender = gender;
            _colour = colour;
            _name = name;
            _age = age;
            _sound = sound;
        }

        //method that tells if animal is sick and needs medication
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

        //abstract method that prints animals info, all animals need to override it
        public abstract void PrintInfo();

        //method that is accessible for all animals
        public void MakeSound()
        {
            Console.WriteLine($"{_name} says *{_sound}*\n");
        }

    }
}
