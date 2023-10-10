using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimalHandler
{
    //base class Animal
    public class Animal
    {
        protected string _gender { get; set; }
        protected string _colour { get; set; }
        protected string _name { get; set; }
        protected int _age { get; set; }
        protected Boolean _healthy { get; set; }


        //Default constructor
        public Animal()
        {
            _gender = "unknown";
            _colour = "unknown";
            _name = "unknown";
            _age = 0;
            _healthy = true;
        }

        //Instance constructor with 4 parameters
        public Animal(string gender, string name, int age, Boolean healthy)
        {

            _gender = gender;
            _name = name;
            _age = age;
            _healthy = healthy;
        }

        //method that tells if animal is sick and needs medication
        public void TellAnimalHealth()
        {
            if (_healthy == true)
            {
                Console.WriteLine($"{_name} is healthy!");
            }
            else
            {
                Console.WriteLine($"{_name} needs medication.");
            }
        }

        //method that tells animals gender/sex
        public void TellGender()
        {
            Console.WriteLine($"{_name} is a {_gender}.");
        }

        //Method that tells the animals age
        public void TellAge()
        {
            if (_age >= 10)
            {
                Console.WriteLine($"{_name} is over 10 years old.");
            }
            else if (_age < 10)
            {
                Console.WriteLine($"{_name} is younger than 10 years.");
            }
        }
    }
}
