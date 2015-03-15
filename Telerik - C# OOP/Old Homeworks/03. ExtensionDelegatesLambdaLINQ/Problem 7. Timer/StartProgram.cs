using System.Collections.Generic;

namespace Problem_7.Timer
{
    public delegate int Del(string param); 
    class StartProgram
    {
        private static int Magic(string a)
        {
            return 5;
        }
        static void Main()
        {
            Del myDelegate = new Del(Magic);
        }
    }
}
