namespace Scoreboard.Classes.GameStatistics;

// match event stores basic information about event which can occur in game like goal, period start/end
// this class is used mainly for exporting minute by minute events in match
public struct MatchEvent
{
    public string EventName { get; set; }

    public string EventInfo { get; set; }
}