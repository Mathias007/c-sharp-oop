using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        private List<Transaction> AllTransactions = new List<Transaction>();

        public static UInt32 accountNumberSeed = 2453453;
        public UInt32 Number { get; }
        public string Owner { get; }
        public decimal balance;

        // DOKOŃCZYĆ LOAN
        public Loan Loan = new Loan();


        public decimal Balance
        {
            get
            {
                decimal transactionsSum = 0;
                foreach (var transaction in AllTransactions)
                {
                    transactionsSum += transaction.Amount;
                }
                return transactionsSum + balance;
            }
            set
            {
                balance = value;
            }
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed++;
            Console.WriteLine($"Utworzono nowe konto z saldem: {initialBalance}");

        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            Console.WriteLine($"Dokonanie wpłaty: {amount}");
            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Nie można wpłacić ujem nej kwoty");
            }
            Transaction deposit = new Transaction(amount, date, note);
            AllTransactions.Add(deposit);
        }


        // UZUPEŁNIĆ METODY
        public void MakeWithdraw()
        {

        }

        public void GiveLoan()
        {

        }

        public void PayLoan()
        {

        }

        public void ListTransaction()
        {

        }

        public void DisplayInfo()
        {

        }

    }
}
