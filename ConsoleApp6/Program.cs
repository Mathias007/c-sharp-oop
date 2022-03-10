using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                playWithAccount();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Nie można uruchomić");
                Console.ReadKey();
            }
        }

        // ROZBUDOWAĆ
        static public void playWithAccount()
        {
            BankAccount bankAccount = new BankAccount("Jan Nowak", 1000);
            bankAccount.MakeDeposit(200, DateTime.Now, "wynagrodzenie"); 
        }
    }

}
