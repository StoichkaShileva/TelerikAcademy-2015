/*
 Define a class that holds information about a mobile phone device: model, manufacturer, price, 
 owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
 Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */

using System.ComponentModel;
using System.Security.Cryptography;

namespace _01.GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartProgram
    {
        private static void Main(string[] args)

        {
            //#Input
            //Console.WriteLine("Enter phone model:");
            //string model = Console.ReadLine();
            //Console.WriteLine("Enter phone manufacturer:");
            //string manufacturer = Console.ReadLine();
            //Console.WriteLine("Enter hours of idle: (Not necessery, press enter to skip!)");
            //string currentHoursIdle = Console.ReadLine();
            //double? currentHoursIdleD = null;
            //if (currentHoursIdle.Length != 0)
            //    currentHoursIdleD = double.Parse(currentHoursIdle);
            //Console.WriteLine("Enter hours of talk: (Not necessery, press enter to skip!)");
            //string currentHoursIdTalk = Console.ReadLine();
            //double? currentHoursTalkD = null;
            //if (currentHoursIdle.Length != 0)
            //    currentHoursTalkD = double.Parse(currentHoursIdTalk);
            //Console.WriteLine("Enter phone display size: (Not necessery, press enter to skip!) ");
            //string currentDisplaySize = Console.ReadLine();
            //double? currentDisplaySizeD = null;
            //if (currentDisplaySize.Length != 0)
            //    currentDisplaySizeD = double.Parse(currentDisplaySize);
            //Console.WriteLine("Enter phone colors: (Not necessery, press enter to skip!)");
            //string currentColor = Console.ReadLine();
            //long colors = 12334123;
            //if (currentColor.Length != 0)
            //{
            //    colors = long.Parse(currentColor);
            //}
            Battery batteryOfGalaxy = new Battery();
            batteryOfGalaxy.HoursIdle = 12;
            batteryOfGalaxy.Model = "SuperChina";
            batteryOfGalaxy.HoursTalk = 3;

            Display superAmoled = new Display(5.5, 16837172361);
            GSM phone = new GSM("Galaxy S6", "Samsung", batteryOfGalaxy, superAmoled);
            phone.Price = 1440;
            Console.WriteLine(phone);
            GSMCallHistoryTest test = new GSMCallHistoryTest();
            test.TestHistoryCalls();
        }
    }
}
