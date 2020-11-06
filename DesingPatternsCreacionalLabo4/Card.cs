using System;
namespace DesingPatternsCreacionalLabo4
{
    public class Card
    {
        public int NumberCard { get; set; }
        public string Password { get; set; }
        public BankAccount Account { get; set; }
        public Card()
        {
        }
        public bool VerifyPassword(string password)
        {
            return password == Password;
        }
        public bool VerifayNumerCard(int numberCard)
        {
            return numberCard == NumberCard;
        }
        public bool VerifyCard(int numberCard,string password)
        {
            return VerifayNumerCard(numberCard) && VerifyPassword(password);
        }
    }
}
