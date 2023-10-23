namespace ZooAnimalHandler
{
    public class Wolf : Canine

    {
        protected string Origin { get; set; }
        //Default constructor
        public Wolf()
        {
            SpeciesOrBreed = "?";
            Origin = "?";
            Fur = "?";
            Gender = "?";
            Colour = "?";
            Name = "?";
            Age = 0;
            Sound = "aoouuuuuuuu";
        }
        public Wolf(string origin, string fur, string colour, string gender, string name, int age, string sound, string speciesOrBreed)
            : base(fur, colour, gender, name, age, sound, speciesOrBreed)
        {
            Origin = origin;
        }
        //unique method for Wolf class
        public void WolfHunt()
        {
            Console.WriteLine($"{Name} sets its eyes on a prey (a chunk of meat on the ground) and strikes! " +
                $"The prey didn't stand a chance, nature is truly vicious.\n");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Wolf info:\nSpecies: {SpeciesOrBreed}\nOrigin: {Origin}\nName: {Name}\nGender: {Gender}\nAge: {Age}\nColour: {Colour}\nFur length: {Fur}\n");
        }
    }
}
