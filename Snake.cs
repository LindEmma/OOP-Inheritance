using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    internal class Snake : Reptile
    {
        protected bool Venomous { get; set; }
        public Snake()
        {
            Venomous = true;
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "?";
        }
        public Snake(string colour, string gender, string name, int age, string sound, bool venomous, string speciesOrBreed)
            : base(colour, gender, name, age, sound, speciesOrBreed)
        {
            Venomous = venomous;
        }
        // unique method for Snake class. If the snake is venomous, user is told to get an antidote.
        public void Bite()
        {
            {
                Console.WriteLine($"{Name} bites you while petting it, rude!");
                if (Venomous == true)
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
            Console.WriteLine($"Snake info:\nSpecies: {SpeciesOrBreed}\nName: {Name}\nGender: {Gender}\nAge: {Age}\nColour: {Colour}\n");
        }
    }
}
