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
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "qwaaaaaak";
            _canFly = false;
            _speciesOrBreed = "?";
        }
        //constructor with parameters
        public Penguin(string colour, string gender, string name, int age, string sound, Boolean canFly, string speciesOrBreed)
            : base(colour, gender, name, age, sound, canFly, speciesOrBreed)
        {
            
        }
        //method that is unique to Penguin class. 
        public void Dive()
        {
            Console.WriteLine($"{_name} dives off the plastic ledge and swims gracefully for the zoo visitors!\n");
        }
        //overrided method
        public override void PrintInfo()
        {
            Console.WriteLine($"Penguin info:\nSpecies:{_speciesOrBreed}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\n");
        }

    }
}
