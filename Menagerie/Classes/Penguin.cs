using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagerie.Classes
{
    internal class Penguin
    {
        public string Type { get; protected set; }
        public string Biome { get; protected set; }
        public int Square { get; set; }
        public string Feed { get; protected set; }
        public bool IsPredator { get; protected set; }
        public string Sound { get; protected set; }

        public string Name { get; set; }
        public double VolumeFeedPerDay { get; set; }
        public int Age { get; set; }

        public Penguin(string name, double volumeFeedPerDay, int age)
        {
            Type = "Пингвин";
            Biome = "Тундра";
            Square = 10;
            Feed = "Рыба";
            IsPredator = true;
            Sound = "Хрю";

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
