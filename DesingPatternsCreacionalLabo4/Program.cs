using System;

namespace DesingPatternsCreacionalLabo4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            client.DepositMoney();
            client.RemoveMoney();
            client.CheckMoney();
        }
    }
}
