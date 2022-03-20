using System;

namespace Scoreboard.Classes
{
    public struct Time
    {
        private int _minutes;
        private int _seconds;

        public int Minutes
        {
            get => _minutes;
            set => _minutes = value;
        }

        public int Seconds
        {
            get => _seconds;
            set => _seconds = value;
        }

        public void AddTime(Time parTime)
        {
            if (IsValidTime(parTime))
            {
                Seconds += parTime.Seconds;
                if (Seconds > 60)
                {
                    Seconds %= 60;
                    Minutes++;
                }
            }
        }

        public void SubtractTime(Time parTime)
        {
            Time help = this;
            if (IsValidTime(parTime))
            {
                if (help.Seconds < parTime.Seconds && help.Minutes-1 >= 0)
                {
                    help.Minutes--;
                    help.Seconds += 60;
                    help.Minutes -= parTime.Minutes;
                    help.Seconds -= parTime.Seconds;
                }
                else
                { 
                    help.Minutes -= parTime.Minutes;
                    help.Seconds -= parTime.Seconds;
                }
                if (IsValidTime(help))
                {
                    Minutes = help.Minutes;
                    Seconds = help.Seconds;
                }
                else
                {
                    throw new InvalidOperationException("Subtract time invalid operation!");
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

        public void TickMinus()
        {
            if (IsZero()) return;
            if (_seconds == 0)
            {
                if (_minutes > 0)
                {
                    _minutes--;
                    _seconds = 60;
                    _seconds--;
                }
            }
            else
            {
                _seconds--;
            }
        }

        public void TickPlus()
        {
            _seconds++;
            if (_seconds == 60)
            {
                _minutes++;
                _seconds = 0;
            }
        }

        public bool IsZero()
        {
            if (_minutes == 0 && _seconds == 0)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string sMinutes;
            string sSeconds;

            if (_minutes < 10)
                sMinutes = "0" + _minutes;
            else
                sMinutes = _minutes.ToString();

            if (_seconds < 10)
                sSeconds = "0" + _seconds;
            else
                sSeconds = _seconds.ToString();

            return $"{sMinutes}{"_"}{sSeconds}";
        }
    }
}
