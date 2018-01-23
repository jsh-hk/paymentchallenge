using PaymentChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentChallenge.Objects
{
    public class DiscoverSimpleInterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(decimal principal)
        {
            return Decimal.Multiply(principal, 0.01m);
        }
    }
}
