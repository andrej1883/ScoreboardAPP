using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scoreboard.Classes.Database
{
    [Serializable]
    public class Database
    {
        private List<Team> _teamList;
        private List<Advertisement> _advList;


        public List<Advertisement> AdvList
        {
            get => _advList;
            set => _advList = value;
        }
        public List<Team> TeamList
        {
            get => _teamList;
            set => _teamList = value;
        }
        public Database()
        {
            _teamList = new List<Team>();
            _advList = new List<Advertisement>();

        }


        public Team FindTeam(string parTeamName)
        {
            foreach (Team t in _teamList)
            {
                if (t.Name.Equals(parTeamName))
                    return t;
            }
            return null;
        }

        public Advertisement FindAdv(string parAdvPath)
        {
            foreach (Advertisement a in _advList)
            {
                if (a.Path.Equals(parAdvPath))
                    return a;
            }
            return null;
        }

        public void OrderAfterLoad()
        {
            int teamCount = _teamList.Count;
            if (teamCount > 0)
            {
                string[] teamNames = new string[teamCount];
                for (int i = 0; i < teamCount; i++)
                {
                    teamNames[i] = _teamList[i].Name;
                }

                Array.Sort(teamNames);

                Team teamH;
                List<Team> sortedTeams = new List<Team>();
                for (int i = 0; i < teamCount; i++)
                {
                    teamH = null;
                    foreach (Team t in TeamList)
                    {
                        if (t.Name.Equals(teamNames[i]))
                            teamH = t;
                    }
                    TeamList.Remove(teamH);
                    sortedTeams.Add(teamH);
                }
                TeamList = sortedTeams;
            }
        }

        public void AddTeam(Team parTeam)
        {
            if (!TeamList.Contains(parTeam) && FindTeam(parTeam.Name) == null && parTeam.Name.Length > 0)
            {
                TeamList.Add(parTeam);
            }
            else
            {
                MessageBox.Show(@"Team was not added! Each team can be added only once! Define at least Team EventName!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveTeam(Team parTeam)
        {
            if (TeamList.Contains(parTeam))
            {
                TeamList.Remove(parTeam);
            }
            else
            {
                MessageBox.Show(@"Team not found", @"Remove team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddAdv(Advertisement parVid)
        {

            if (!_advList.Contains(parVid) && FindAdv(parVid.Path) == null && parVid.Path.Length > 0)
            {
                _advList.Add(parVid);
            }
            else
            {
                MessageBox.Show(@"Video was not added! Each video can be added only once! Define at least Video path!" , @"Add advertisement Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveAdv(Advertisement parVid)
        {
            if (_advList.Contains(parVid))
            {
                _advList.Remove(parVid);
            }
            else
            {
                MessageBox.Show(@"Video not found", @"Remove advertisement Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
