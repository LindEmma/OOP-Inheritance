using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    internal class Snake : Reptile
    {
        protected Boolean _venomous { get; set; }
        public Snake()
        {
            _venomous = true;
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "?";
        }
        public Snake(string colour, string gender, string name, int age, string sound, Boolean venomous, string speciesOrBreed)
            : base(colour, gender, name, age, sound, speciesOrBreed)
        {
            _venomous = venomous;
        }
        // unique method for Snake class. If the snake is venomous, user is told to get an antidote.
        public void Bite()
        {
            {
                Console.WriteLine($"{_name} bites you while petting it, rude!");
                if (_venomous == true)
                {
                    Console.WriteLine($"The snake is poisonous...You should probably ask the zoo keepers for an antidote.\n");
                }
                else
                {
                    Console.WriteLine($"It hurt but wont kill you.\n");
                }
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Snake info:\nSpecies: {_speciesOrBreed}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\n");
        }
    }
}
