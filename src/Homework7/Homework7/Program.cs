using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PersonInfo { };
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter your weight(kg): ");
            user.weight = int.Parse(Console.ReadLine());
            Console.Write("Enter your height (sm): ");
            user.height = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Menu(user);
        }
        private static void Run(int weight)
        {
            var startTime = DateTime.Now;
            KeyByUser();
            var endTime = DateTime.Now;
            long Ticks = endTime.Ticks - startTime.Ticks;
            double runTime = (double) Ticks / 10000000;
            double distance = 3.3 * runTime;
            int calories = weight / 12;
            Console.WriteLine($"fff{runTime}");
            Console.WriteLine(distance);
            Console.ReadKey();

        }



        private static void Walking(int weight)
        {
            var startTime = DateTime.Now;
            KeyByUser();
            var endTime = DateTime.Now;
            long Ticks = endTime.Ticks - startTime.Ticks;
            int walkTime = (int) Ticks / 10000000;
            double distance = 1.39 * walkTime;
            int calories = weight / 5;
            Console.WriteLine(walkTime);
            Console.WriteLine(distance);
            Console.ReadKey();
        }

        private static void KeyByUser()
        {
            ConsoleKey userInputKey = default;
            while (userInputKey != ConsoleKey.Escape)
            {
                userInputKey = Console.ReadKey().Key;
            }
        }

        private static void Menu(PersonInfo user)
        {
            Console.WriteLine($"Nice to meet you { user.Name}!" + "\nWhat's the plan ?");
            Console.WriteLine(" ==============================");
            Console.WriteLine("|                              |\n| 1. Runing - Press 1          |\n|                              |");
            Console.WriteLine("|                              |\n| 2. Walking - Press 2         |\n|                              |");
            Console.WriteLine("|                              |\n| 3. Eating - Press 3          |\n|                              |");
            Console.WriteLine("|                              |\n| 4. Watch progress - Press 4  |\n|                              |");
            Console.WriteLine(" ==============================");
            var userInput = Console.ReadKey().Key;
            switch (userInput)
            {
                case ConsoleKey.NumPad1:
                    Run(user.weight);
                    break;
                case ConsoleKey.NumPad2:
                    Walking(user.weight);
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
            };
        }
    }
}
