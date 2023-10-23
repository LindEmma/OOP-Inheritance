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
        protected string Gender { get; set; }
        protected string Colour { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Sound { get; set; }
        protected string SpeciesOrBreed { get; set; }

        //default constructor
        public Animal()
        {
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "?";
            SpeciesOrBreed = "?";
        }
        //Instance constructor with 6 parameters
        public Animal(string colour,string gender,string name, int age, string sound,string speciesOrBreed)
        {
            Gender = gender;
            Colour = colour;
            Name = name;
            Age = age;
            Sound = sound;
            SpeciesOrBreed = speciesOrBreed;
        }
        //method with if-statement that tells if animal is sick and needs medication. Same for all inheriting classes. 
        public void TellAnimalHealth()
        {
            Random random = new Random();
            int x = random.Next(0, 2);

            if (x == 0)
            {
                Console.WriteLine($"{Name} is healthy!");
            }
            else if (x == 1)

            {
                Console.WriteLine($"{Name} is sick and needs medication!");
            }
            Console.WriteLine();
        }
        //virtual method that prints the animals info, can be overrided in inheriting classes. 
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Animal info:\nSpecies: {SpeciesOrBreed}\nName: {Name}\nGender: {Gender}\nAge: {Age}\nColour: {Colour}\n");
        }

        //method that is accessible in all classes. Same for each class.
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says *{Sound}*\n");
        }

    }
}
