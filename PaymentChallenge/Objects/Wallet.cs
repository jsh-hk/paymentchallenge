using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentChallenge.Objects
{
    public class Wallet
    {
        public List<CreditCard> CreditCards { get; set; }

        public Wallet()
        {
            CreditCards = new List<CreditCard>();
        }

        public Wallet(List<CreditCard> creditCards)
        {
            CreditCards = creditCards;
        }

        public decimal GetTotalInterest()
        {
            return CreditCards.Sum(c => c.GetInterest());
        }
    }
}
