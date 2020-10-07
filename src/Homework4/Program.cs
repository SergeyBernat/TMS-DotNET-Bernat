using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStop = false;
            var taskNumber = 1;
            var task = new List<TaskManager>();
            InputTaskList(task, inputStop, taskNumber);
            OutputTaskInfo(task);
            static void InputTaskList(List<TaskManager> task, bool inputStop, int taskNumber)
            {
                while (!inputStop)
                {
                    Console.WriteLine("=======");
                    Console.WriteLine("Enter task name and decription:");
                    var _task = new TaskManager
                    {
                        NumberTask = taskNumber,
                        Name = Console.ReadLine(),
                        Description = Console.ReadLine()
                    };
                    taskNumber++;
                    task.Add(_task);
                    inputStop = InputStop();
                }
            }
        }

        private static void autoExit(List<TaskManager> task)
        {
            if (!(task.Count > 0))
            {
                Console.WriteLine("Congratulations! all tasks are completed!" + "\nthe program is over.");
                Environment.Exit(-1);
            }
        }

        private static bool InputStop()
        {
            Console.Write("Press any key to add new tasks" +
            "\nPress Enter to filling out the list ");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Enter;
        }

        private static bool Exit()
        {
            Console.Write("Press Q/q to rage quit");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Q;
        }

        private static void OutputTaskInfo(List<TaskManager> task)
        {
            var exit = false;
            while (!exit)
            {
                autoExit(task);
                Console.WriteLine("\n=======");
                foreach (var _task in task)
                {
                    _task.GetInfo();
                }
                Console.WriteLine("\n=======");
                Console.WriteLine("After completing the task, you can remove it by specifying the number");
                Console.WriteLine("Press any key to continue" + "\nEnter the № of completed task: ");
                var inputIndex = int.Parse(Console.ReadLine());
                task.RemoveAt(inputIndex -= 1);
                foreach (var _task in task)
                {
                    _task.GetInfo();
                }
                exit = Exit();
            }
        }
    }
}