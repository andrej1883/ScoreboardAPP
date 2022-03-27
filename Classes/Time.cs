namespace Scoreboard.Classes;

public struct Time
{
    public int Minutes { get; set; }

    public int Seconds { get; set; }


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