using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    internal class Tortoise:Reptile
    {
        public Tortoise()
        {
            SpeciesOrBreed = "?";
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "?";
        }
        public Tortoise(string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(colour, gender, name, age, sound, speciesOrBreed)
        {   
        }
        //unique method for Turtle class
        public void Hide()
        {
            Console.WriteLine($"{Name} is a bit scared and hides in its shell\n");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Tortoise info:\nSpecies: {SpeciesOrBreed}\nName: {Name}\nGender: {Gender}\nAge: {Age}\nColour: {Colour}\n");
        }
    }
}
