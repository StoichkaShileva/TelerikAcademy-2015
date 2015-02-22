using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            //Bank account
            Console.WriteLine("Enter first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter middle name:");
            string middlename = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter amount of money:");
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bank Name:");
            string bankName = Console.ReadLine();
            Console.WriteLine("Enter IBAN");
            ulong iban = ulong.Parse(Console.ReadLine());

        }
    }
}
