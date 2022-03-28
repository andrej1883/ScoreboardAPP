namespace Scoreboard.Classes.GameStatistics;

// this class holds statistics for each team in game statistics
public struct TeamStatistics
{
    public int FaceOffs { get; set; }

    public string Name { get; set; }

    public int Goals { get; set; }

    public int Shots { get; set; }
}