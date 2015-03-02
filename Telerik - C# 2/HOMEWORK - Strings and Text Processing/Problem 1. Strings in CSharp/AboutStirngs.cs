using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Strings_in_CSharp
{
    class Strings
    {
        static void Main(string[] args)
        {
            //Desribe the strings
            /*
             In computer programming, a string is traditionally a sequence of characters, 
             * either as a literal constant or as some kind of variable. 
            */

            //What is typical for the string data type?
            /*
             Typical for the string data type is that strings are sequence of chars
             */

            //Describe the most important methods of the String class.
            /*
             string yeah = "yeah i am string";
             int index = yeah.IndexOf("am");
             cw(index); -:> returns 7
             if IndexOf returns -1, searched string doesnt exist in the main string
             
             -@ LastIndexOf
             - vrushta indexa na posledno namereniq element
             
             -@ Substring
             ot koi index, kolko simvola da vzeme
             string test = "asdf man";
             string newStr = test.Substring(3, 1);
             -> ot 3 index da vzeme 1 simvol
             cw(newStr); -:> 'f'
             
             -@ Remove
             obratnoto na Substirng -> remove reje ot index do index, a substring vzima ot index do index
             
             -@ Split
             returns string[] array
             string[] arrSplited = s.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
             
             -@ Replace
             returns new string
             string a = "pesho";
             string replacedString = a.Replace("e", "x");
             
             -@ Trim
             maha otlqvo i otdqsno white-spaces
             
             -@ String Builder
             using System.Text;
             StringBuilder sb = new StringBuilder(Capacity);
             sb.Append("asd");
             sb.AppendLine("Asadf");
             sb.Clear();
             */
        }
    }
}
