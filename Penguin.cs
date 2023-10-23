using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    public class Penguin:Bird
    {
        //default constructor
        public Penguin()
        {
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "qwaaaaaak";
            CanFly = false;
            SpeciesOrBreed = "?";
        }
        //constructor with parameters
        public Penguin(string colour, string gender, string name, int age, string sound, Boolean canFly, string speciesOrBreed)
            : base(colour, gender, name, age, sound, canFly, speciesOrBreed)
        {
            
        }
        //method that is unique to Penguin class. 
        public void Dive()
        {
            Console.WriteLine($"{Name} dives off the plastic ledge and swims gracefully for the zoo visitors!\n");
        }
        //overrided method
        public override void PrintInfo()
        {
            Console.WriteLine($"Penguin info:\nSpecies:{SpeciesOrBreed}\nName: {Name}\nGender: {Gender}\nAge: {Age}\nColour: {Colour}\n");
        }

    }
}
