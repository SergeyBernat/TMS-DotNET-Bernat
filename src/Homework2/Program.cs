using System;

internal enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

internal class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter number day of week:");

            string userInput = Console.ReadLine();
            if (userInput.ToUpper() == "Y")
            {
                break;
            }

            int parsedUserInput = Convert.ToInt32(userInput);
            Console.WriteLine((Days)parsedUserInput);
        }
    }
}