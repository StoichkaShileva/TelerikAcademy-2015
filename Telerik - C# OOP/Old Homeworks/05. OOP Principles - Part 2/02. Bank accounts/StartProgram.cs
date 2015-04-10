/*
 @@@ Problem 2. Bank accounts @@@
 * A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based).
 * Deposit accounts are allowed to deposit and with draw money.
 * Loan and mortgage accounts can only deposit money.
 * All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
 * Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
 * Deposit accounts have no interest if their balance is positive and less than 1000.
 * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
 * Your task is to write a program to model the bank system by classes and interfaces.
 * You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/

using System;

namespace _02.Bank_accounts
{
    class StartProgram
    {
        static void Main()
        {
            Bank dsk = new Bank("DSK");
            Customer telerik = new Company("Telerik");

            DepositAccount deposit = new DepositAccount(dsk, telerik, 1200, 8);
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Bank name: [{0}]", dsk.BankName);
            Console.WriteLine("Customer name: [{0}]", telerik.Name);
            Console.WriteLine("Creating a deposit in bank {0} with customer {1} which has balance {2} and interest rate {3}", dsk.BankName, telerik.Name, deposit.Balance, deposit.InterestRate);
            Console.WriteLine("Calculate interest amount for 6 months: [{0}]", deposit.CalculateInterestAmount(6));
            Console.WriteLine(new string('-',30));

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Before withdrawing {0}", deposit.Balance);
            deposit.WithDraw(300);
            Console.WriteLine("After withdrawing 300: {0}", deposit.Balance);
            Console.WriteLine(new string('-', 30));
        }
    }
}
