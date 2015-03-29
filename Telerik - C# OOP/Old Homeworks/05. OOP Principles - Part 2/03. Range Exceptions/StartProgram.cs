namespace _03.Range_Exceptions
{
    class StartProgram
    {
        static void Main()
        {
            throw new InvalidRangeException<int>("Invalid input!", 1, 10000);
            
            //Uncomment code below to see that InvalidRangeException works also with dates
            
            //throw new InvalidRangeException<DateTime>("something is invalid", new DateTime(1990, 1, 1), new DateTime(2013, 12, 23));
        }
    }
}
