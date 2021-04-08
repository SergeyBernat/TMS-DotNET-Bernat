using System;

namespace Homework6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("============================ATM============================");
            Console.WriteLine("Select operation:" + "\nPress W. Withdraw money" + "\nPress D. Deposit money" + "\nPress I. Check your card balance" + "\nPress ESC. Exit");
            Console.WriteLine("===========================================================");
            decimal userInputSum = 0;

            while (1 == 1)
            {
                Console.WriteLine("=>>--------------------------------------------------------\n");
                var userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.W || userInput == ConsoleKey.D)
                {
                    Console.WriteLine("|Enter sum|: \n");
                    userInputSum = decimal.Parse(Console.ReadLine());
                }
                Card card = new Card();
                ATM atm = new ATM();
                card.notify += GetInfo;
                switch (userInput)
                {
                    case ConsoleKey.W:
                        if (userInputSum < Card._cardBalance && userInputSum < ATM.atmCashBalance)
                        {
                            card.Withdraw(userInputSum);
                            atm.atmTake(userInputSum);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, but there is not enough cash in the ATM");
                        }
                        break;

                    case ConsoleKey.D:
                        card.Deposit(userInputSum);
                        atm.atmPut(userInputSum);
                        break;

                    case ConsoleKey.I:
                        card.BalanceInfo();
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
                static void GetInfo(decimal _cardBalance) => Console.WriteLine($"|Your balance|: {_cardBalance}");
            }
        }
    }
}
