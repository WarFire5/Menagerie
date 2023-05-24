using Menagerie.Classes;

Elephant elephant = new Elephant("Матильда", 5, 20);
elephant.MakeASound();
elephant.Eating("Сено");
elephant.Playing();
Console.WriteLine();

Penguin penguin = new Penguin("Петя", 0.3, 5);
penguin.MakeASound();
penguin.Eating("Рыба");
penguin.Playing();
Console.WriteLine();

Tiger tiger = new Tiger("Симба", 5, 5);
tiger.MakeASound();
tiger.Eating("Мясо");
tiger.Playing();
Console.WriteLine();

Console.ReadLine();