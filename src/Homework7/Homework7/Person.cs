using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Homework7
{
    class Person
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public static void GetFullInfo(List<Running> runningList, List<Walking> walkingList)
        {
            foreach (var item in runningList)
            {
                Console.WriteLine($"    {item.dateTrainig}" +
                    $"\nYour run {(int)item.Distance} meters " +
                    $"\nfor {(int)item.RunTime} sec " +
                    $"\nand burned {(int)item.Calories} kcal ~ " +
                    $"{Math.Round(0.1296 * (int)item.Calories, 2)} gramm of fat\n");
            }

            foreach (var item in walkingList)
            {
                Console.WriteLine($"    {item.dateTrainig}" +
                    $"\nYour walking {(int)item.Distance} meters " +
                    $"\nfor {(int)item.WalkTime} sec " +
                    $"\nand burned ~ {(int)item.Calories} kcal ~ " +
                    $"{Math.Round(0.1296 * (int)item.Calories, 2)} gramm of fat\n");
            }
        }
    }
}
