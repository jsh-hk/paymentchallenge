using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentChallenge.Objects
{
    public class Person
    {
        public List<Wallet> Wallets { get; set; }

        public Person(Wallet wallet)
        {
            Wallets = new List<Wallet> { wallet };
        }

        public Person(List<Wallet> wallets)
        {
            Wallets = wallets;
        }        

        public decimal GetTotalInterest()
        {
            return Wallets.Sum(w => w.GetTotalInterest());
        }
    }
}
