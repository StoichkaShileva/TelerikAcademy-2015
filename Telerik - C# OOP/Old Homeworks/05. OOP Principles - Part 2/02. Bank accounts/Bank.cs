using System;
using System.Collections.Generic;

namespace _02.Bank_accounts
{
    public class Bank
    {
        private string bankName;
        private List<Account> accounts;

        public Bank(string inputName)
        {
            this.BankName = inputName;
            this.accounts = new List<Account>();
        }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        public List<Account> Accounts
        {
            get
            {
                if (this.accounts.Count == 0)
                    throw new ArgumentNullException("There are not any accounts in the bank.");
                else
                    return accounts;

            }
            private set { accounts = value; }
        }

        public void AddAcount(Account account)
        {
            this.accounts.Add(account);
        }

       
    }
}