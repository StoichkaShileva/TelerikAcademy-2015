using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___PHP_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string phpCode = Console.ReadLine();
            long uniqueVariablesNum = 0;
            List<string> variables = new List<string>();
            bool inComments = false;
            for (int i = 5; i < phpCode.Length-2; i++)
            {
                if (phpCode[i] == '#')
                {
                    inComments = true;
                }
                if (phpCode[i] == '/' && phpCode[i + 1] == '*' && phpCode[i-1] != '\\')
                {
                    inComments = true;
                }
                if (phpCode[i] == '*' && phpCode[i + 1] == '/' && phpCode[i - 1] != '\\')
                {
                    inComments = false;
                }
                if (!inComments)
                {
                    if (phpCode[i] == '$' && phpCode[i - 1] != '\\' && (char.IsLetter(phpCode[i+1]) || phpCode[i+1] == '_'))
                    {
                        int x = i;
                        char curr = phpCode[x + 1];
                        string nameOfVariable = string.Empty;
                        bool isConsisting = false;
                        while (!char.IsWhiteSpace(curr))
                        {
                            curr = phpCode[x + 1];
                            nameOfVariable += curr;
                            x++;
                        }
                        for (int j = 0; j < variables.Count; j++)
                        {
                            if (variables[i] == nameOfVariable)
                            {
                                isConsisting = true;
                                i += x;
                                break;
                            }
                        }
                        if(isConsisting == false)
                            variables.Add(nameOfVariable);
                        i += x;
                    }
                }
            }
            uniqueVariablesNum = variables.Count;
            Console.WriteLine(uniqueVariablesNum);
            foreach (var variable in variables)
            {
                Console.WriteLine(variable);
            }
        }
    }
}
