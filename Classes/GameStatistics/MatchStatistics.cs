using System;
using System.Collections.Generic;
using System.IO;
using Scoreboard.Classes.Database;

namespace Scoreboard.Classes.GameStatistics
{
    public class MatchStatistics
    {
        private TeamStatistics[] _teamStats;
        private List<MatchEvent> _matchEvents;
        private Time _actualTime;

        public List<MatchEvent> MatchEvents
        {
            get => _matchEvents;
            set => _matchEvents = value;
        }

        public TeamStatistics[] TeamStats
        {
            get => _teamStats;
            set => _teamStats = value;
        }

        public MatchStatistics(string team1Name, string team2Name)
        {
            _matchEvents = new List<MatchEvent>();
            _teamStats = new TeamStatistics[2];
            ResetStats(team1Name,team2Name);
        }

        public void CreateGoalEvent(int parTeam, Player parPlayerG, Player parPlayerA1, Player parPlayerA2, Time parTime)
        {
            UpdateTime(parTime);
            TeamStatistics team = _teamStats[parTeam - 1];
            string nameEvent = _actualTime.ToString()+ " " + team.Name + " scored!"  ;
            string infoEvent = parPlayerG.Name + " shot a goal with assistance of: " + parPlayerA1.Name + " " + parPlayerA2.Name;
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void CreatePenaltyEvent(int parTeam, Player parPlayerG, Time penalLength)
        {
            TeamStatistics team = _teamStats[parTeam - 1];
            string nameEvent = _actualTime.ToString();
            string infoEvent = "Player from team: "+ team.Name + " was sent for penalty: "+ penalLength.ToString();
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }
        public void EndPenaltyEvent(int parTeam, Player parPlayerG)
        {
            TeamStatistics team = _teamStats[parTeam - 1];
            string nameEvent = _actualTime.ToString();
            string infoEvent = "Penalty for team: " + team.Name + " has ended";
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void CreateFaceOffEvent(int parTeam)
        {
            TeamStatistics team = _teamStats[parTeam - 1];
            string nameEvent = _actualTime.ToString();
            string infoEvent = team.Name + " won face-off!"  ;
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void CreateStartPeriodEvent(int parPeriod)
        {
            string score = String.Empty;
            if (parPeriod > 1)
            {
                score = "with score: " + _teamStats[0].Name + " " + _teamStats[0].Goals + " : " + _teamStats[1].Goals + " "+ _teamStats[1].Name;
            }
            string nameEvent = _actualTime.ToString();
            string infoEvent = parPeriod + ". period started " + score;
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void CreateLastMinuteEvent()
        {
            string score = _teamStats[0].Name + " " + _teamStats[0].Goals + " : " + _teamStats[1].Goals + " "+ _teamStats[2].Name;
            string nameEvent = _actualTime.ToString();
            string infoEvent = "Last minute of match with score: " + score;
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void CreateEndPeriodEvent(int parPeriod)
        {
            string score = _teamStats[0].Name + " " + _teamStats[0].Goals + " : " + _teamStats[1].Goals + " "+ _teamStats[2].Name;
            string nameEvent = _actualTime.ToString();
            string infoEvent = parPeriod + ".  started with score: " + score;
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = infoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void CreateManualEvent(string parInfoEvent)
        {
            string nameEvent = _actualTime.ToString();
            MatchEvent help = new MatchEvent() {EventName = nameEvent, EventInfo = parInfoEvent};
            _matchEvents.Add(help);
            ExportEvent(help);
        }

        public void SetName(int team, string parName)
        {
            _teamStats[team-1].Name = parName;
        }

        public void UpdateTime(Time parTime)
        {
            _actualTime = parTime;
        }

        private void ExportEvent(MatchEvent parEvent)
        {
            string dir = Environment.CurrentDirectory + "\\Events";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.WriteAllText(Path.Combine(dir, parEvent.EventName + ".txt"), parEvent.EventInfo);
        }

        private void ResetStats(string team1Name, string team2Name)
        {
            SetName(1,team1Name);
            SetName(2,team2Name);
            Time zero = new Time() {Minutes = 0, Seconds = 0};
            for (int i = 0; i < _teamStats.Length; i++)
            {
                _teamStats[i].Goals = 0;
                _teamStats[i].Shots = 0;
                _teamStats[i].PenalTime = zero;
                _teamStats[i].FaceOffs = 0;
                _teamStats[i].Shots = 0;
            }
        }
    }
}
