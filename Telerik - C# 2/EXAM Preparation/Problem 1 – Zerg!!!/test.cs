using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class MultiverseCommunication
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine(); //TELERIK-ACADEMY
            string value = v.ToUpper();
            Dictionary<string, char> table = new Dictionary<string, char>();
            table["Rawr"] = '0';
            table["Rrrr"] = '1';
            table["Hsst"] = '2';
            table["Ssst"] = '3';
            table["Grrr"] = '4';
            table["Rarr"] = '5';
            table["Mrrr"] = '6';
            table["Psst"] = '7';
            table["Uaah"] = '8';
            table["Uaha"] = '9';
            table["Zzzz"] = '10';
            table["Bauu"] = '11';
            table["Djav"] = '12';
            table["Myau"] = '13';
            table["Gruh"] = '14';
            string thirdteenNumberSystem = "";
            //List<string> values = new List<string>();
            //for (int i = 0; i < value.Length; i++)
            //{
            //    values.Add(value[i].ToString());
            //}
            //var list = Enumerable
            //    .Range(0, value.Length / 3)
            //    .Select(i => value.Substring(i * 3, 3))
            //    .ToList();
            //var res = string.Join(" ", list);

            //for (int i = 0; i < table.Count; i++)
            //{
            //    var item = table.ElementAt(i);
            //    if (value.Contains(item.Key))
            //    {
            //        thirdteenNumberSystem += item.Value;
            //    }
            //}
            //Console.WriteLine(thirdteenNumberSystem);
            List<string> list = new List<string>();
            for (int i = 0; i < value.Length; i += 3)
            {
                string currentStr = "";
                currentStr += value[i];
                currentStr += value[i + 1];
                currentStr += value[i + 2];
                list.Add(currentStr);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < table.Count; j++)
                {
                    var item = table.ElementAt(j);
                    var itemKey = item.Key;
                    var itemValue = item.Value;
                    if (list[i] == item.Key)
                    {
                        thirdteenNumberSystem += item.Value;
                    }
                }
            }
            //Console.WriteLine(thirdteenNumberSystem);
            //int num = Convert.ToInt32(thirdteenNumberSystem);
            //List<int> finalNumbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //int currentTime = 1;
            //for (int i = thirdteenNumberSystem.Length - 1; i >= 0; i--)
            //{
            //    for (int j = 0; j < currentTime; j++)
            //    {
            //        int currentNum = 1;
            //        if (thirdteenNumberSystem[i] == '0')
            //        {
            //            currentNum *= (0 * 13);
            //        }
            //        if (thirdteenNumberSystem[i] == '1')
            //        {
            //            currentNum *= (1 * 13);
            //        }
            //        else if (thirdteenNumberSystem[i] == '2')
            //        {
            //            currentNum *= (2 * 13);
            //        }
            //        else if (thirdteenNumberSystem[i] == 'A')
            //        {
            //            currentNum *= (11 * 13);
            //        }
            //        else if (thirdteenNumberSystem[i] == 'B')
            //        {
            //            currentNum *= (11 * 13);
            //        }
            //        else if (thirdteenNumberSystem[i] == 'C')
            //        {
            //            currentNum *= (12 * 13);
            //        }
            //    }
            //    currentTime++;
            //}
            double counter = 0;
            double endNum = 0;
            for (int i = thirdteenNumberSystem.Length - 1; i >= 0; i--)
            {
                if (thirdteenNumberSystem[i] == 'A')
                {
                    endNum += Math.Pow(13, counter) * 10;
                }
                else if (thirdteenNumberSystem[i] == 'B')
                {
                    endNum += Math.Pow(13, counter) * 11;
                }
                else if (thirdteenNumberSystem[i] == 'C')
                {
                    endNum += Math.Pow(13, counter) * 12;
                }
                else
                {
                    endNum += Math.Pow(13, counter) * int.Parse(thirdteenNumberSystem[i].ToString());
                }
                counter++;
            }
            Console.WriteLine(endNum);
            //int tupaPromenliva;
            //for (int i = thirdteenNumberSystem.Length -1; i >= 0; i--)
            //{

            //}

            ////foreach (KeyValuePair<string, int> entry in table)
            //{
            //    Console.WriteLine(entry.Key);
            //}
            //int dev = value.Length / 3;
            //string[] elements = new string[dev];
            //for (int i = 0; i < elements.Length; i++)
            //{
            //    elements[i] = 
            //}
        }
    }
}