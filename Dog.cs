using System;

namespace ZooAnimalHandler
{
    //sub class Dog, inherits from class Animal
    public class Dog : Canine
    {
        Random random = new Random();

        //default constructor
        public Dog()
        {
            _fur = "unknown";
            _gender = "unknown";
            _colour = "unknown";
            _name = "unknown";
            _age = 0;
            _sound = "Wuff wuff";
            _speciesOrBreed = "?";
        }

        public Dog(string fur, string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(fur, colour, gender, name, age, sound, speciesOrBreed) //Animal constructor is inherited??
        {
        }

        //method that is unique to Dog class
        public void PlayCatch()
        {
            string[] catchResult = {$"You throw a ball and {_name} eagerly catch it and runs back to you. She wants you to throw it again, and again... \nThe circle never ends.\n",
            $"You throw a ball but {_name} just looks at you with a side eye. You interrupted its nap, how rude.\n", $"You throw a ball and {_name} tries to catch it" +
            $" but miss and run into a tree. So clumsy, but adorable!\n"};
            
            //randomizes the outcome of PlayCatch from the catchResult array. Dog will react in different ways.
            Console.WriteLine(catchResult[random.Next(catchResult.Length)]);
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Dog info:\nBreed: {_speciesOrBreed}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\nFur length: {_fur}\n");
        }
    }
}

//Hierarchial inheritance. När flera klasser ärver från samma

//single inheritance: när en klass ärver från en annan

//Multiple inheritance: när en klass ärver från flera (interface)

//Multilevel inheritance: när en klass ärver från en annan derived klass. (viktig labb 6)
//Class A{}, Class B:A{}, class C:B{} osv. Klass C ärver fält och metoder från både A och B.

//