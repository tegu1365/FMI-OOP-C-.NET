using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public class Time
    {
		#region Properties
		private int hour;

		public int Hour
		{
			get { return hour; }
			set { hour = value >= 0 && value < 24 ? value : 0; }
		}

		private int minute;

		public int Minute
		{
			get { return minute; }
			set { minute = value >= 0 && value < 60 ? value : 0; }
		}

        private int second;

        public int Second
        {
            get { return second; }
            set { second = value >= 0 && value < 60 ? value : 0; }
        }
        #endregion

        #region Constructors
        public Time()
		{
			Hour = 0;
			Minute = 0;
			Second = 0;
		}

		public Time(int hour, int minute, int second)
		{
			Hour = hour;
			Minute = minute;
			Second = second;
		}

		#endregion

		public override string ToString()
			=> $"Time [{hour}:{minute}:{second}]";
    }
}