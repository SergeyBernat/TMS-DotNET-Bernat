using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class TaskManager
    {
        private readonly DateTime _dateTime = DateTime.Now;

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberTask { get; set; }

        public void GetInfo()
        {
            Console.Write($"Task № {NumberTask}. ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"DateTime: {_dateTime}");
            Console.WriteLine();
        }
    }
}