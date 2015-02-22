/* 
 A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
 Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Print_Company_Information
{
    class printCompanyName
    {
        static void Main(string[] args)
        {
            //Company name
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            //Company address
            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();
            //Company phone number
            Console.Write("Enter company phone number: ");
            string companyPhone = Console.ReadLine();
            //Company fax number
            Console.Write("Enter company fax number: ");
            string faxNumber = Console.ReadLine();
            //Company web site and manager
            Console.Write("Enter company site: ");
            string webSite = Console.ReadLine();
            //Company Manager first name
            Console.Write("Enter company manager first name: ");
            string managerFirstName = Console.ReadLine();
            //Company Manager last name
            Console.Write("Enter company manager last name: ");
            string managerLastName = Console.ReadLine();
            //Company Manager age
            Console.Write("Enter manager age: ");
            int managerAge = int.Parse(Console.ReadLine());
            //Company Manager phone number
            Console.Write("Enter manager phone: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhone);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerFirstName + " " + managerLastName, managerAge, managerPhoneNumber);

        }
    }
}
