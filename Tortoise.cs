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
            _speciesOrBreed = "?";
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "?";
        }
        public Tortoise(string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(colour, gender, name, age, sound, speciesOrBreed)
        {   
        }
        //unique method for Turtle class
        public void Hide()
        {
            Console.WriteLine($"{_name} is a bit scared and hides in its shell\n");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Tortoise info:\nSpecies: {_speciesOrBreed}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\n");
        }
    }
}
