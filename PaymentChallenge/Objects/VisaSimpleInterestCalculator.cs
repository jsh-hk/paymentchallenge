using PaymentChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentChallenge.Objects
{
    public class VisaSimpleInterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(decimal principal)
        {
            return Decimal.Multiply(principal, 0.1m);
        }
    }
}
