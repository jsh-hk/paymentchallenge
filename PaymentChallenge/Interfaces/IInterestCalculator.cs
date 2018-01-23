using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentChallenge.Interfaces
{
    public interface IInterestCalculator
    {
        decimal CalculateInterest(decimal principal);
    }
}
