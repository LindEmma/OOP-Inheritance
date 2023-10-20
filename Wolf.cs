using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooAnimalHandler
{
    public class Wolf:Canine
        
    {
        //Default constructor
        public Wolf()
        {
            _fur = "?";
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "aoouuuuuuuu";
        }
        public Wolf(string fur, string colour, string gender, string name, int age,string sound)
            : base(fur, colour, gender, name, age,sound)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Wolf info:\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\nFur length: {_fur}");
            Console.WriteLine();
        }
    }
}
