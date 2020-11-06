using System;
namespace DesingPatternsCreacionalLabo4
{
    public class BankAccount
    {
        public int NumberAccount { get; set; }
        public int Balance { get; set; }
        public BankAccount()
        {
        }
        public void SetData(int numberAccount,int balance)
        {
            NumberAccount = numberAccount;
            Balance = balance;
        }
        public bool RemoveMoney(int quantity)
        {
            Console.WriteLine("---RETIRANDO DINERO---");
            if (quantity > Balance)
            {
                Console.WriteLine("Saldo insuficiente para retirar esa cantidad");
                return false;
            }
            else
            {
                Balance = Balance - quantity;
                Console.WriteLine("Retiro este monto: " + quantity);
                return true;
            }
        }
        public bool Deposit(int quantity)
        {
            Console.WriteLine("---DEPOSITANTO DINERO---");
            if (quantity>0)
            {
                Balance = Balance + quantity;
                Console.WriteLine("Deposito completado, Saldo Actual: " + Balance);
                return true;
            }
            else
            {
                Console.WriteLine("Cantidad incorrecta, intente otra vez");
                return false;
            }
        }
    }
}
