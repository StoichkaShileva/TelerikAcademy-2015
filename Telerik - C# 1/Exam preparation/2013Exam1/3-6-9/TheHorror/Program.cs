using System;

class Program
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        decimal counter = 0;
        decimal result = 0;
        for (int i = 0; i < num.Length; i++)
        {
            decimal n = decimal.Parse(num[i].ToString());
            if (n == 0 || n == 1 || n == 2 || n == 3 || n == 4 || n == 5 || n == 6 || n == 7 || n == 8 || n == 9)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    result += num[i] - '0';
                }
            }

        }
        Console.Write(counter + " " + result);
    }
}