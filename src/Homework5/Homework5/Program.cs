using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello averyone to my ZOO!");
            Console.WriteLine();
            Console.WriteLine("Sorry:( but the my Zoo is empty!");
            Console.WriteLine();
            Console.WriteLine("Buy new animal?");
            Console.WriteLine();
            Console.WriteLine("Available command: \nWolf - to buy wolf " +
                "\nHawk - to buy hawk " +
                "\nEnd - finish shopping and count how many animals we bought " +
                "\nlist - see all buy animals! " +
                "\nExit - exit the program");
            var animalWolfs = new List<Wolfs>();
            var animalHawks = new List<Hawks>();
            var stopBuy = false;
            while (!stopBuy)
            {
                var userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "wolf":
                        GetWolf(animalWolfs);
                        break;
                    case "hawk":
                        GetHawk(animalHawks);
                        break;
                    case "end":
                        int valueAnimal = GetCoundOfList(animalHawks, animalWolfs);
                        Console.WriteLine($"You buy {valueAnimal} animal/s");
                        continue;
                    case "list":
                        Console.WriteLine("\nAll your animal on Zoo\n");
                        foreach (var wolf in animalWolfs)
                        {
                            wolf.GetInfoW();
                        }
                        foreach (var hawk in animalHawks)
                        {
                            hawk.GetInfoH();
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Thanks for your help bro!");
                        Environment.Exit(-1);
                        break;
                }

                static void GetWolf(List<Wolfs> animalWolfs)
                {
                    Random rnd = new Random();
                    string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska", "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla"};

                    int mIndex = rnd.Next(malePetNames.Length);
                    int rndAgeW = Wolfs.GetRandomAgeWolfs();
                    var rndNameW = malePetNames[mIndex];
                    Wolfs wolf = new Wolfs();
                    {
                        Wolfs.GetRandomAgeWolfs();
                        wolf.Name = rndNameW;
                        wolf.Age = rndAgeW;
                        Console.Write("You buy WOLF!\n");
                    }
                    animalWolfs.Add(wolf);
                }

                static void GetHawk(List<Hawks> animalHawks)
                {
                    Random rnd = new Random();
                    string[] animalName = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska", "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla"};

                    int index = rnd.Next(animalName.Length);

                    int rndAgeH = Hawks.GetRandomAgeHawks();
                    var rndNameH = animalName[index];
                    Hawks hawk = new Hawks();
                    {
                        Hawks.GetRandomAgeHawks();
                        hawk.Name = rndNameH;
                        hawk.Age = rndAgeH;
                        Console.Write("You buy HAWK!\n");
                    }
                    animalHawks.Add(hawk);
                }
            }
        }

        private static int GetCoundOfList(List<Hawks> animalHawks, List<Wolfs> animalWolfs)
        {
            int valueAnimal = animalHawks.Count + animalWolfs.Count;
            return valueAnimal;
        }
    }
}
