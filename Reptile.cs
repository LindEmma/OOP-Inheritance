using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    abstract class Reptile:Animal
    {
        // default constructor
        public Reptile()
        {
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "?";
            SpeciesOrBreed = "?";
        }
        //constructor 
        public Reptile(string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            :base(colour,gender,name,age,sound, speciesOrBreed)
        {  
        }
        // Method unique for classes inheriting Reptile
        public void SunBathe()
        {
            Console.WriteLine($"{Name} finds the best spot to sun bathe: a flat stone directly beneath the UV-lamp. Life is good!\n");
        }
        public override void PrintInfo()
        {
        }
    }
}
