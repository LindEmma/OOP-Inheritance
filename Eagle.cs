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
           
            _canFly = true;
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "squiii squiiiii";
            _speciesOrBreed = "?";
        }
        //constructor with parameters
        public Eagle(string colour, string gender, string name, int age, string sound, string speciesOrBreed, Boolean canFly)
            : base(colour, gender, name, age, sound,canFly, speciesOrBreed)
        {
        }
        //unique method for eagle
        public void EagleHunt()
        {
            Console.WriteLine($"{_name} sets it's eyes on the prey and viciously attacks the unknowing prey (a meat slab on a stick held by a zoo worker)\n " +
                $"this is the natural order of things.\n");
        }
        //overrided method to suit eagles properties better
        public override void PrintInfo()
        {
            Console.WriteLine($"Eagle info:\nSpecies: {_speciesOrBreed}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\n");
        }
    }
}
