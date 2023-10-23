using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    public class Eagle:Bird
    {
        //default constructor
        public Eagle()
        {     
            CanFly = true;
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "squiii squiiiii";
            SpeciesOrBreed = "?";
        }
        //constructor with parameters
        public Eagle(string colour, string gender, string name, int age, string sound, string speciesOrBreed, bool canFly)
            : base(colour, gender, name, age, sound,canFly, speciesOrBreed)
        {
        }
        //unique method for eagle
        public void EagleHunt()
        {
            Console.WriteLine($"{Name} sets it's eyes on the prey and viciously attacks the unknowing prey (a meat slab on a stick held by a zoo worker)\n " +
                $"this is the natural order of things.\n");
        }
        //overrided method to suit eagles properties better
        public override void PrintInfo()
        {
            Console.WriteLine($"Eagle info:\nSpecies: {SpeciesOrBreed}\nName: {Name}\nGender: {Gender}\nAge: {Age}\nColour: {Colour}\n");
        }
    }
}
