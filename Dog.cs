namespace ZooAnimalHandler
{
    //sub class Dog
    public class Dog : Animal
    {
        protected string _fur { get; set; }
        protected string _sound { get; set; }
        protected string _species { get; set; }
        public Dog() { }
        public Dog(string species, string name, string gender, int age, Boolean healthy, string fur, string sound)
        {
            _species = "dog";
            _name = name;
            _gender = gender;
            _age = age;
            _healthy = healthy;
            _fur = fur;
            _sound = sound;
        }

        public void Catch()
        {
            if (_gender.ToLower() == "female")
            {
                _gender = "girl";
            }
            else if (_gender.ToLower() == "male")
            {
                _gender = "boy";
            }
            else
            {
                _gender = "dog";
            }
            Console.WriteLine($"{_name} caught the ball you just threw! Good {_gender}!");
        }

        public void PrintDogInfo()
        {
            Console.WriteLine($"Species: {_species}, name: {_name}, gender: {_gender}, age: {_age}, healthy: {_healthy}, fur length: {_fur}, sound: {_sound}.");
        }

    }
}
