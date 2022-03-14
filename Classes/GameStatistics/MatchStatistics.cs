using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboard.Classes
{
    public class MatchStatistics
    {
        private TeamStatistics[] _teamStats;
        private List<MatchEvent> _matchEvents;

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

        public MatchStatistics()
        {
            _teamStats = new TeamStatistics[2];
        }

        public void CreateGoalEvent()
        {
        }

        public void CreatePenaltyEvent()
        {
        }

        public void CreateStartPeriodEvent()
        {
        }

        public void CreateLastMinuteEvent()
        {
        }

        public void CreateEndPeriodEvent()
        {
        }

        public void CreateFaceOffEvent()
        {
        }

        public void CreateManualEvent()
        {

        }

    }
}
