using PaymentChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentChallenge.Objects
{
    public class MastercardSimpleInterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(decimal principal)
        {
            return Decimal.Multiply(principal, 0.05m);
        }
    }
}
