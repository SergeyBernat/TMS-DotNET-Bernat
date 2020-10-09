using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    public class Hawks : AnimalBase, InterfaceHawks
    {
        public static int GetRandomAgeHawks()
        {
            Random rndAge = new Random();
            int value = rndAge.Next(1, 17);
            return value;
        }
        public void GetInfoH()
        {
            Console.WriteLine("Hawk");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("");
        }
    }
}
