/*
 Using delegates write a class Timer that can execute certain method at each t seconds.
 */
namespace Problem_7.Timer
{
    using System.Timers;
    using System.Threading;
    public class Timer
    {
        public int Seconds { get; set; }

        public delegate void DelegateMethod(string param);

        private DelegateMethod InputMethod;

        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        public DelegateMethod Method
        {
            get { return this.InputMethod; }
            set { this.InputMethod = value; }
        }

        public void Start(string inputVal)
        {
            while (true)
            {
                InputMethod(inputVal);
                Thread.Sleep(Seconds*1000);
            }
        }

    }
}
