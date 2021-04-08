using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class ATM
    {
        public static decimal atmCashBalance { get; private set; } = 1000M;

        public void atmTake(decimal userInputSum)
        {
            atmCashBalance -= userInputSum;
        }
        public void atmPut(decimal userInputSum)
        {
            atmCashBalance += userInputSum;
        }
    }
}