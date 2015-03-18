/*Using delegates write a class Timer that can execute certain method at each t seconds.*/
namespace Problem_7.Timer
{
    using System;

    class StartProgram
    {
        private static void MethodA(string val)
        {
            Console.WriteLine("Method A with {0} value is invoked!", val);
        }

        private static void MethodB(string val)
        {
            Console.WriteLine("Method B! +> {0}", val);
        }
        public static void Main()
        {
            Timer t = new Timer(2); //Here we set seconds
            //Adding to the delegate some methods
            t.Method += MethodA; 
            t.Method += MethodB;
            //Invoking all methods with string parameter "wazup"
            t.Start("wazup");
        }
    }
}
