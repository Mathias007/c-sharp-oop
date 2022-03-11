using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PlayWithAccount();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Wystąpił problem z uruchomieniem - {e.Message}");
                Console.ReadKey();
            }
        }

        static public void PlayWithAccount()
        {
            int maxLoan = 1000;
            bool isMenuOpened = true;

            Console.WriteLine("Witamy w PKO BP. Dziękujemy za zainteresowanie naszą ofertą. Zacznijmy procedurę zakładania konta.");
            Console.WriteLine("Najpierw podaj imię i nazwisko właściciela: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Świetnie, {name}! Teraz wpisz kwotę, którą wpłacasz jako saldo początkowe: ");
            int balance = int.Parse(Console.ReadLine());
            var Account = new BankAccount(name, balance, maxLoan);
            Console.WriteLine($"Doskonale! Konto zostało założone na nazwisko {name} z saldem początkowym {balance}. Ze względu na wybraną ofertę bank przewiduje dla tego rachunku odgórny limit kredytu w kwocie {maxLoan}.");

            while (isMenuOpened)
            {
                Console.WriteLine("Przejdźmy do menu Twojego nowego konta. Poniżej znajdziesz listę możliwych operacji. Zatwierdź wybór poprzez naciśnięcie odpowiedniego klawisza");
                DateTime date = DateTime.Today;

                string[] accountOperations = new string[] { "Wpłata środków na konto", "Wypłata środków z konta", "Zaciągnięcie kredytu", "Spłacenie kredytu", "Przegląd historii rachunku", "Informacje o koncie." };
                Console.WriteLine("Jakie działanie chcesz wykonać? Wybierz odpowiednie działanie z listy poniżej:");
                for (int i = 0; i < accountOperations.Length; i++)
                {
                    Console.WriteLine($"       {i} - {accountOperations[i].ToUpper()}");
                }

                Console.Write("     Twój wybór: ");
                var choosenOption = int.Parse(Console.ReadLine());
                Console.WriteLine($"Wybrałeś {accountOperations[choosenOption].ToUpper()}. \n");

                switch (choosenOption)
                {
                    case 0:
                        Console.WriteLine("Wpisz kwotę do wpłaty: ");
                        int DepositAmount = int.Parse(Console.ReadLine());
                        Account.MakeDeposit(DepositAmount, date, accountOperations[choosenOption]);
                        break;
                    case 1:
                        Console.WriteLine("Wpisz kwotę do wypłaty: ");
                        int WithdrawAmount = int.Parse(Console.ReadLine());
                        Account.MakeWithdraw(WithdrawAmount, date, accountOperations[choosenOption]);
                        break;
                    case 2:
                        Console.WriteLine("Wpisz kwotę pobieranego kredytu: ");
                        int credit = int.Parse(Console.ReadLine());
                        Account.GiveLoan(credit, date, accountOperations[choosenOption]);
                        break;
                    case 3:
                        Console.WriteLine("Wpisz kwotę spłacanego kredytu: ");
                        int repayment = int.Parse(Console.ReadLine());
                        Account.PayLoan(repayment, date, accountOperations[choosenOption]);
                        break;
                    case 4:
                        Account.ListTransactions();
                        break;
                    case 5:
                        Account.DisplayInfo();
                        break;
                    default:
                        throw new NotSupportedException("Nieprawidłowy wybór!");
                }

                Console.WriteLine("Czy chcesz kontynuować? Jeżeli tak, naciśnij Y. Jeżeli nie - wybierz dowolny klawisz, aby zakończyć pracę kalkulatora.");
                Console.Write("Twoja decyzja: ");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.WriteLine("Dziękujemy za skorzystanie z programu.");
                    isMenuOpened = !isMenuOpened;
                }
                Console.Clear();

            }
            Console.ReadKey();

        }
    }
}
