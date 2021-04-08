using System;
using System.Collections.Generic;

namespace Homework7
{
    internal class UserInteface
    {
        public static void Menu(Person user, List<Running> runningList, List<Walking> walkingList, Action<ConsoleColor, string> action)
        {
            string lS = "|                              |"; // lineSymbol
            string eS = "                               "; // emptySymbol
            Console.WriteLine($"\n{eS}     What's the plan today ?");
            Console.WriteLine($"{eS} ==============================");
            Console.WriteLine($"{eS}{lS}\n{eS}| Runing - Press [R]           |\n{eS}{lS}");
            Console.WriteLine($"{eS}{lS}\n{eS}| Walking - Press [W]          |\n{eS}{lS}");
            Console.WriteLine($"{eS}{lS}\n{eS}| Watch progress - Press [P]   |\n{eS}{lS}");
            Console.WriteLine($"{eS}{lS}\n{eS}| Exit - Press [ESC]           |\n{eS}{lS}");
            Console.WriteLine($"{eS} ==============================");
            Console.WriteLine("");
            for (; ; )
            {
                var userInput = Console.ReadKey().Key;
                switch (userInput)
                {
                    case ConsoleKey.R:
                        var RunInfo = Running.Run((int)user.Weight);
                        Running run = new Running()
                        {
                            RunTime = RunInfo.runTime,
                            Calories = RunInfo.calories,
                            Distance = RunInfo.distance,
                            dateTrainig = RunInfo.startTime
                        };
                        runningList.Add(run);
                        action(ConsoleColor.Red, "Cool RUN!");
                        Console.WriteLine($"\n{eS}        What's next?");
                        break;

                    case ConsoleKey.W:
                        var WalkInfo = Walking.Walk((int)user.Weight);
                        Walking walk = new Walking()
                        {
                            WalkTime = WalkInfo.walkTime,
                            Calories = WalkInfo.calories,
                            Distance = WalkInfo.distance,
                            dateTrainig = WalkInfo.startTime
                        };
                        walkingList.Add(walk);
                        action(ConsoleColor.Green, "have a good walk?:)");
                        Console.WriteLine($"\n{eS}        What's next?");
                        break;

                    case ConsoleKey.P:
                        Console.WriteLine($"/Your progress in {DateTime.Now.DayOfWeek.ToString().ToLower()} {user.Name}:\n");
                        Person.GetFullInfo(runningList, walkingList);
                        Console.WriteLine($"\n{eS}        What's next?");
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine($"qHave a nice day {user.Name}!");
                        Environment.Exit(0);
                        break;
                };
            }
        }
    }
}
