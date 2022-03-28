using System;
using System.IO;
using Scoreboard.Classes.Database;

namespace Scoreboard.Classes.GameStatistics;

// creates specific events for minute by minute export and also holds match statistics for each team
public class MatchStatistics
{

    public string ExpoPath { get; set; }
    public bool ExportEvents { get; set; } = true;
    public TeamStatistics[] TeamStats { get; }

    public MatchStatistics(string parTeam1Name, string parTeam2Name)
    {
        TeamStats = new TeamStatistics[2];
        ResetStats(parTeam1Name,parTeam2Name);
    }

    public void CreateGoalEvent(int parTeam, Player parPlayerG, Player parPlayerA1, Player parPlayerA2, Time parTime)
    {
        var team = TeamStats[parTeam - 1];
        var nameEvent = $"{parTime} {team.Name} scored!";
        var infoEvent =
            $"{parPlayerG.Name} shot a goal with assistance of: {parPlayerA1.Name} {parPlayerA2.Name}";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void CreatePenaltyEvent(int parTeam, Time parPenalLength,Time parTime)
    {
        var team = TeamStats[parTeam - 1];
        var nameEvent = parTime.ToString();
        var infoEvent = $"Player from team: {team.Name} was sent for penalty: {parPenalLength}";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void EndPenaltyEvent(int parPosition, Time parTime)
    {
        var team = parPosition is 0 or 1 ? TeamStats[0] : TeamStats[1];
        var nameEvent = parTime.ToString();
        var infoEvent = $"Penalty for team: {team.Name} has ended";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void CreateFaceOffEvent(int parTeam, Time parTime)
    {
        var team = TeamStats[parTeam - 1];
        var nameEvent = parTime.ToString();
        var infoEvent = $"{team.Name} won face-off!";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void CreateTimeoutEvent(int parTeam, Time parTime)
    {
        var team = TeamStats[parTeam - 1];
        var nameEvent = parTime.ToString();
        var infoEvent = $"{team.Name} took timeout.";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void CreateStartPeriodEvent(int parPeriod, Time parTime)
    {
        var score = string.Empty;
        if (parPeriod > 1)
        {
            score =
                $"with score: {TeamStats[0].Name} {TeamStats[0].Goals} : {TeamStats[1].Goals} {TeamStats[1].Name}";
        }
        var nameEvent = parTime.ToString();
        var infoEvent = $"{parPeriod}. period started {score}";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void CreateLastMinuteEvent(int parPeriod, Time parTime)
    {
        var score = $"{TeamStats[0].Name} {TeamStats[0].Goals} : {TeamStats[1].Goals} {TeamStats[1].Name}";
        var nameEvent = parTime.ToString();
        var infoEvent = $"Last minute of {parPeriod}. period with score: {score}";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    public void CreateEndPeriodEvent(int parPeriod, Time parTime)
    {
        var score = $"{TeamStats[0].Name} {TeamStats[0].Goals} : {TeamStats[1].Goals} {TeamStats[1].Name}";
        var nameEvent = parTime.ToString();
        var infoEvent = $"{parPeriod}. period ended with score: {score}";
        MatchEvent help = new() {EventName = nameEvent, EventInfo = infoEvent};
        ExportEvent(help);
    }

    // option for game board operator to create custom event with custom name and body
    public void CreateManualEvent(string parInfoEvent, string parNameEvent)
    {
        MatchEvent help = new() {EventName = parNameEvent, EventInfo = parInfoEvent};
        ExportEvent(help);
    }

    // sets name of team from parameter
    private void SetName(int parTeam, string parName)
    {
        TeamStats[parTeam-1].Name = parName;
    }

    // exports events to txt file to specified or selected folder for minute by minute export 
    private void ExportEvent(MatchEvent parEvent)
    {
        ExpoPath ??= $"{Environment.CurrentDirectory}\\Events";
        if (!ExportEvents) return;
        if (!Directory.Exists(ExpoPath))
        {
            Directory.CreateDirectory(ExpoPath);
        }
        File.AppendAllText(Path.Combine(ExpoPath, $"{parEvent.EventName}.txt"), parEvent.EventInfo + Environment.NewLine);
        
    }

    private void ResetStats(string parTeam1Name, string parTeam2Name)
    {
        SetName(1,parTeam1Name);
        SetName(2,parTeam2Name);
        for (var i = 0; i < TeamStats.Length; i++)
        {
            TeamStats[i].Goals = 0;
            TeamStats[i].Shots = 0;
            TeamStats[i].FaceOffs = 0;
            TeamStats[i].Shots = 0;
        }
    }
}