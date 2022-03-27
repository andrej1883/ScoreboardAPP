using System;

namespace Scoreboard.Classes;

public struct Time
{
    public int Minutes { get; set; }

    public int Seconds { get; set; }


    public void SubtractTime(Time parTime)
    {
        var help = this;
        if (!IsValidTime(parTime)) return;
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

    private static bool IsValidTime(Time parTime)
    {
        return parTime.Minutes >= 0 && parTime.Seconds is >= 0 and < 60;
    }

    public void TickMinus()
    {
        if (IsZero()) return;
        if (Seconds == 0)
        {
            if (Minutes <= 0) return;
            Minutes--;
            Seconds = 60;
            Seconds--;
        }
        else
        {
            Seconds--;
        }
    }

    public void TickPlus()
    {
        Seconds++;
        if (Seconds != 60) return;
        Minutes++;
        Seconds = 0;
    }

    public bool IsZero()
    {
        return Minutes == 0 && Seconds == 0;
    }

    public override string ToString()
    {
        var sMinutes = Minutes < 10 ? $"0{Minutes}" : Minutes.ToString();

        var sSeconds = Seconds < 10 ? $"0{Seconds}" : Seconds.ToString();

        return $"{sMinutes}_{sSeconds}";
    }
}