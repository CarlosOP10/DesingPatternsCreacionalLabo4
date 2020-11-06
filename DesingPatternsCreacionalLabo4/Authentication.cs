using System;
using System.Collections;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo4
{
    public class Authentication
    {
        public IList<Card> Cards { get; set; }
        public Authentication()
        {
            Cards = new List<Card>();
            Cards.Add(new Card()
            {
                NumberCard=123,
                Password="password",
                Account=new BankAccount()
                {
                    NumberAccount=12332,
                    Balance=2000
                }
            });
            Cards.Add(new Card()
            {
                NumberCard = 1234,
                Password = "password2",
                Account = new BankAccount()
                {
                    NumberAccount = 1222,
                    Balance = 3000
                }
            });
            Cards.Add(new Card()
            {
                NumberCard = 12345,
                Password = "password3",
                Account = new BankAccount()
                {
                    NumberAccount = 12435,
                    Balance = 6000
                }
            });
        }

        public Card ReadCard(int NuberCard)
        {
            foreach(var card in Cards)
            {
                if (card.NumberCard == NuberCard)
                    return card;
            }
            return null;
        }
        
        public BankAccount GetBankAccount(int NumberCard)
        {
            foreach (var card in Cards)
            {
                if (card.NumberCard == NumberCard)
                    return card.Account;
            }
            return null;
        }
    }
}
