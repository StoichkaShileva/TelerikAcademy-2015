using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _02.Bank_accounts
{

    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
    }

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

    public class Account : Bank, IAccount
    {

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public Account(string inputBankName)
            : base (inputBankName)
        {
            
        }

        public Account(string inputBankName, Customer inputCustomer, decimal inputBalance, decimal inputInterestRate)
            : this(inputBankName)
        {
            this.Customer = inputCustomer;
            this.Balance = inputBalance;
            this.InterestRate = inputInterestRate;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            return this.InterestRate*months;
        }

    }

    public class Customer : Account
    {
        private string name;
        public Customer(string inputBankName, string inputCustomerName)
            : base(inputBankName)
        {
            this.Name = inputCustomerName;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }

    public class Individual : Customer
    {
        public Individual(string inputName)
            : base(inputName)
        {
            
        }
    }

    public class Company : Customer
    {
        
    }

    class Program
    {
        static void Main()
        {
            
        }
    }
}
