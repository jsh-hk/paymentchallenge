using PaymentChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentChallenge.Objects
{
    public class CreditCard
    {
        public decimal Balance { get; set; }

        IInterestCalculator InterestCalculator { get; set; }

        public CreditCard(decimal balance, IInterestCalculator interestCalculator)
        {
            Balance = balance;
            InterestCalculator = interestCalculator;
        }        

        public CreditCard(IInterestCalculator interestCalculator)
        {
            Balance = 0;
            InterestCalculator = interestCalculator;
        }

        public decimal GetInterest()
        {
            return InterestCalculator.CalculateInterest(Balance);
        }
    }
}
