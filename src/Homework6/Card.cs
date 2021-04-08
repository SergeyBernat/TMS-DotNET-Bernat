using System;

namespace Homework6
{
    public class Card
    {
        public event Action<decimal> notify;

        public static decimal _cardBalance { get; private set; } = 1500M;

        public void Withdraw(decimal userInputSum)
        {
            if (_cardBalance > 0)
                _cardBalance -= userInputSum;
            notify.Invoke(_cardBalance);
        }

        public void Deposit(decimal userInputSum)
        {
            _cardBalance += userInputSum;
            notify.Invoke(_cardBalance);
        }

        public void BalanceInfo()
        {
            notify.Invoke(_cardBalance);
        }
    }
}