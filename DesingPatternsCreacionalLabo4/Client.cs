using System;
namespace DesingPatternsCreacionalLabo4
{
    public class Client
    {
        FacadaATM facadaATM;
        public Client()
        {
            facadaATM = new FacadaATM();
        }
        public void DepositMoney()
        {
            facadaATM.DepositMoney();
        }
        public void RemoveMoney()
        {
            facadaATM.RemoveMoney();
        }
        public void CheckMoney()
        {
            facadaATM.PrintTicket();
        }
    }
}
