namespace Menagerie.Classes
{
    internal class Elephant
    {
        public string Type { get; protected set; }
        public string Biome { get; protected set; }
        public int Square { get; set; }
        public string Feed { get; protected set; }
        public bool IsPredator { get; protected set; }
        public string Sound { get; protected set; }

        public string Name { get; set; }
        public int VolumeFeedPerDay { get; set; }
        public int Age { get; set; }

        public Elephant(string name, int volumeFeedPerDay, int age)
        {
            Type = "Слон";
            Biome = "Пустыня";
            Square = 10;
            Feed = "Сено";
            IsPredator = false;
            Sound = "Ауф";

            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
        }
        public void Eating(string food)
        {
            Console.WriteLine($"{Name} покушал");
        }
        public void MakeASound()
        {
            Console.WriteLine($"{Name} издал звук {Sound}");
        }
        public void Playing()
        {
            Console.WriteLine($"{Name} поиграл");
        }
    }
}
