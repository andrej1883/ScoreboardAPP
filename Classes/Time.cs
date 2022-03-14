using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard.Classes
{
    public struct Time
    {
        private int _minutes;
        private int _seconds;

        public int Minutes
        {
            get => _minutes;
            set 
            {
                if (value < 60 && value > 0)
                {
                    _minutes = value;
                }
            }
        }

        public int Seconds
        {
            get => _seconds;
            set 
            {
                if (value < 60 && value > 0)
                {
                    _seconds = value;
                }
            }
        }

        public void AddTime(Time parTime)
        {
            if (IsValidTime(parTime))
            {
                _seconds += parTime.Seconds;
                if (_seconds > 60)
                {
                    _seconds %= 60;
                    _minutes++;
                }
            }
        }


        public bool IsValidTime(Time parTime)
        {
            if (parTime.Minutes >= 0 && parTime.Seconds >= 0 &&
                parTime.Seconds < 60)
            {
                return true;
            }
            return false;
        }



    }
}
