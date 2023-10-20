namespace ZooAnimalHandler
{
    public class Wolf : Canine

    {
        protected string _origin { get; set; }
        //Default constructor
        public Wolf()
        {
            _speciesOrBreed = "?";
            _origin = "?";
            _fur = "?";
            _gender = "?";
            _colour = "?";
            _name = "?";
            _age = 0;
            _sound = "aoouuuuuuuu";
        }
        public Wolf(string origin, string fur, string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(fur, colour, gender, name, age, sound, speciesOrBreed)
        {
            _origin = origin;
        }
        //unique method for Wolf class
        public void WolfHunt()
        {
            Console.WriteLine($"{_name} sets its eyes on a prey (a chunk of meat on the ground) and strikes! " +
                $"The prey didn't stand a chance, nature is truly vicious.\n");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Wolf info:\nSpecies: {_speciesOrBreed}\nOrigin: {_origin}\nName: {_name}\nGender: {_gender}\nAge: {_age}\nColour: {_colour}\nFur length: {_fur}\n");
        }
    }
}
