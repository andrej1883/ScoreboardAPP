using System;

namespace Scoreboard.Classes
{
    public struct Time
    {
        public int Minutes { get; set; }

        public int Seconds { get; set; }

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
            return $"{Minutes}{"_"}{Seconds}";
        }
    }
}
