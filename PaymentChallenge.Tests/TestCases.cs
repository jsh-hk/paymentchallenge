using PaymentChallenge.Objects;
using System;
using System.Collections.Generic;
using Xunit;

namespace PaymentChallenge.Tests
{
    public class TestCases
    {
        [Fact]
        public void SinglePersonSingleWallet()
        {
            var creditCards = new List<CreditCard> {
                new CreditCard(100, new VisaSimpleInterestCalculator()),
                new CreditCard(100, new MastercardSimpleInterestCalculator()),
                new CreditCard(100, new DiscoverSimpleInterestCalculator())
            };            
            var wallet = new Wallet(creditCards);
            var person = new Person(wallet);

            Assert.Equal(10, wallet.CreditCards[0].GetInterest());
            Assert.Equal(5, wallet.CreditCards[1].GetInterest());
            Assert.Equal(1, wallet.CreditCards[2].GetInterest());

            Assert.Equal(16, wallet.GetTotalInterest());
        }

        [Fact]
        public void SinglePersonMultipleWallets()
        {
            var wallet1 = new Wallet(new List<CreditCard> {
                new CreditCard(100, new VisaSimpleInterestCalculator()),
                new CreditCard(100, new DiscoverSimpleInterestCalculator())
            });
            var wallet2 = new Wallet(new List<CreditCard> {
                new CreditCard(100, new MastercardSimpleInterestCalculator())
            });

            var wallets = new List<Wallet> { wallet1, wallet2 };
            var person = new Person(wallets);

            Assert.Equal(11, wallet1.GetTotalInterest());
            Assert.Equal(5, wallet2.GetTotalInterest());

            Assert.Equal(16, person.GetTotalInterest());
        }

        [Fact]
        public void MultiplePeopleMultipleWallets()
        {
            var wallet1 = new Wallet(new List<CreditCard> {
                new CreditCard(100, new MastercardSimpleInterestCalculator()),
                new CreditCard(100, new MastercardSimpleInterestCalculator()),
                new CreditCard(100, new VisaSimpleInterestCalculator())
            });
            var wallet2 = new Wallet(new List<CreditCard> {
                new CreditCard(100, new MastercardSimpleInterestCalculator())
            });

            Person person1 = new Person(wallet1);
            Person person2 = new Person(wallet2);

            Assert.Equal(20, person1.GetTotalInterest());
            Assert.Equal(20, wallet1.GetTotalInterest());
            Assert.Equal(5, person2.GetTotalInterest());
            Assert.Equal(5, wallet2.GetTotalInterest());
        }
    }
}
