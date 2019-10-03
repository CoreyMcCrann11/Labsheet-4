using System;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstbankAccount;
            firstbankAccount = new BankAccount();

            firstbankAccount.accountNumber = 4532;
            firstbankAccount.accountHolder = "John Marston";
            firstbankAccount.Balance = 455;
            
        }
    }
}
