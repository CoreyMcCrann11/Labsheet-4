using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    class BankAccount
    {
        private int accountnumber;

        public int accountNumber
        {
            get
            {
                return accountnumber;
            }

            set
            {
                accountnumber = value;
            }
        }

        private string accountholder;

        public string accountHolder
        {
            get
            {
                return accountholder;
            }

            set
            {
                accountholder = value;
            }
        }

        private int balance;
        
        public int Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }
    }
}
