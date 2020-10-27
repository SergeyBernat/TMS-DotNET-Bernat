using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<ConsoleColor, string> action;
            action = SetTextColor;
            var runningList = new List<Running>();
            var walkingList = new List<Walking>();
            GetInfoByUserAndRunMenu(runningList, walkingList, action);
        }
        private static void GetInfoByUserAndRunMenu(List<Running> runningList, List<Walking> walkingList, Action<ConsoleColor, string> action)
        {
            var user = new Person { };
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter your weight(kg): ");
            user.Weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height (sm): ");
            user.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (user.Height > 65 && user.Height < 272 && user.Weight > 30)
            {
                double BMI = GetBMI(user);
                double GetBMI(Person user) { double BMI = user.Weight / ((user.Height / 100) * (user.Height / 100)); return BMI; }
                Console.WriteLine($"Nice to meet you { user.Name}! \nYour BMI: {Math.Round(BMI, 1)}");
            }
            else
            {
                throw new ArgumentException("Height or weight is impossible");
            }
            UserInteface.menu(user, runningList, walkingList, action);
        }
        public static void SetTextColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{text}");
            Console.ResetColor();
        }
        public static void GetKeyByUser()
        {
            Console.WriteLine("/Press Enter after trening");
            ConsoleKey userInputKey = default;
            while (userInputKey != ConsoleKey.Enter)
            {
                userInputKey = Console.ReadKey().Key;
            }
        }


    }
}

