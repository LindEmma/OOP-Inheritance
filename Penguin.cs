using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    public class Penguin:Bird
    {
        string _penguinSpecies { get; set; }

        //default constructor
        public Penguin()
        {
            _penguinSpecies = "?";
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "qwaaaaaak";
            _canFly = false;
        }
        //constructor with parameters
        public Penguin(string colour, string gender, string name, int age, string sound, Boolean canFly, string penguinSpecies)
            : base(colour, gender, name, age, sound, canFly)
        {
            _penguinSpecies = penguinSpecies;
        }
        //method that is unique to Penguin class. 
        public void Dive()
        {
            Console.WriteLine($"{_name} dives off the plastic ledge and swims gracefully for the zoo visitors!");
        }
        //overrided method
        public override void PrintInfo()
        {
            Console.WriteLine($"Penguin info:\nSpecies:{_penguinSpecies}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\nAbility to fly:{_canFly}");
            Console.WriteLine();
        }

    }
}
