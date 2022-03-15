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
                    if (IsValidTime(help))
                    {
                        _minutes = help.Minutes;
                        _seconds = help.Seconds;
                    }
                    else
                    {
                        throw new InvalidOperationException("Subtract time invalid operation!");
                    }
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

        public override string ToString()
        {
            return $"{_minutes}{"_"}{_seconds}";
        }
    }
}
