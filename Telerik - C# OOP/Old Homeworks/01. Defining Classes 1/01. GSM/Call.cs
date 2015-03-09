namespace _01.GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private long dialedPhone;
        private long number;
        private double duration;

        public Call(DateTime date, DateTime time, long dialedPhone, long number, double duration) : base()
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.number = number;
            this.duration = duration;
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public long DialedPhone
        {
            get { return this.dialedPhone; }
        }

        public long Number
        {
            get { return this.number; }
        }
        public double Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }
    }
}
