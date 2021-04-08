using System;

namespace Homework5
{
    public class Wolfs : AnimalBase, InterfaceWolfs
    {
        public static int GetRandomAgeWolfs()
        {
            Random rndAge = new Random();
            int value = rndAge.Next(1, 8);
            return value;
        }

        public void GetInfoW()
        {
            Console.WriteLine("Wolf");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("");
        }
    }
}
