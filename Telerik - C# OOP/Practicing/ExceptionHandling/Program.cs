
namespace ExceptionHandling
{
    using System;
    public class AnException : ApplicationException
    {
        public AnException(string msg)
            :base(msg)
        {
            
        }
    }
    class StartProgramxceptions
    {
        static void Main()
        {
            try
            {
                throw new AnException("something is invalid");
            }
            catch (AnException exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
