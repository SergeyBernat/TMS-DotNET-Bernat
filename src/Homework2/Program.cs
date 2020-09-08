using System;
enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number day of week:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((Days)userInput);

    }
}