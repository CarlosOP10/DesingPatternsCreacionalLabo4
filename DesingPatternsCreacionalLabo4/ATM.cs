using System;
namespace DesingPatternsCreacionalLabo4
{
    public class ATM
    {

        public ATM()
        {
        }
        public int InserdCard()
        {
            int NumberCard;
            Console.WriteLine("--------Introduciendo tarjeta--------");
            Console.WriteLine("Introdusca el numero de su tarjeta");
            NumberCard=Convert.ToInt16(Console.ReadLine());
            return NumberCard;
        }
        public string InsertPassword()
        {
            string password;
            Console.WriteLine("--------Introduciendo Contraseña--------");
            Console.WriteLine("Introdusca su contraseña");
            password = Console.ReadLine();
            return password;
        }
        public int InsertMoney()
        {
            int amount;
            Console.WriteLine("Introdusca el monto de dinero");
            amount = Convert.ToInt16(Console.ReadLine());
            return amount;
        }
        public void PrintTicket(BankAccount bankAccount)
        {
            Console.WriteLine("-------TICKET------");
            Console.WriteLine("Numero de Cuenta: "+bankAccount.NumberAccount);
            Console.WriteLine("Saldo Actual: " + bankAccount.Balance);

        }
    }
}
