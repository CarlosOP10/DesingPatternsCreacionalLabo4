using System;
namespace DesingPatternsCreacionalLabo4
{
    public class FacadaATM
    {
        Authentication authentication = new Authentication();
        ATM atm = new ATM();
        BankAccount bankAccount=null;
        int NumberIntents = 3;
        public FacadaATM()
        {
        }
        public void InsertCardtoATM()
        {
            int iterator = 0;
            bool passwordVerify = false;
            Card card = null;
           
            do
            {
                iterator++;
                card = authentication.ReadCard(atm.InserdCard());
                if (card == null)
                    Console.WriteLine("Numero de tarjeta incorrecto, Intentos Restantes: " + (NumberIntents-iterator));
            } while (iterator < NumberIntents && card == null);
            iterator = 0;
            if(card!=null)
            {
                do
                {
                    iterator++;
                    passwordVerify = card.VerifyPassword(atm.InsertPassword());
                    if (!passwordVerify)
                        Console.WriteLine("Contraseña Incorreta, intentos restantes: " + (NumberIntents - iterator));
                    else
                        bankAccount= card.Account;
                } while (iterator < 3 && !passwordVerify);
            }
            if (bankAccount == null)
                Console.WriteLine("Autentifiacion Incorrecta");
        }
        public bool RemoveMoney()
        {
            if (bankAccount == null)
                InsertCardtoATM();
            if(bankAccount!=null)
                return bankAccount.RemoveMoney(atm.InsertMoney());
            return false;
        }
        public bool DepositMoney()
        {
            if (bankAccount == null)
                InsertCardtoATM();
            if (bankAccount != null)
                return bankAccount.Deposit(atm.InsertMoney());
            return false;
        }
        public void PrintTicket()
        {
            if (bankAccount == null)
                InsertCardtoATM();
            if (bankAccount != null)
                atm.PrintTicket(bankAccount);
          
        }
    }
}
