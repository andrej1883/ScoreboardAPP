using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scoreboard.Classes
{
    [Serializable]
    public class Database
    {
        private List<Team> _teamList;
        private List<AdvertisementVideo> _advertisement;



        public List<Team> TeamList
        {
            get => _teamList;
            set => _teamList = value;
        }

        public Database()
        {
            _teamList = new List<Team>();

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

        public void PostLoad()
        {
            int pocet = _teamList.Count;
            if (pocet > 0)
            {
                string[] pole = new string[pocet];
                for (int i = 0; i < pocet; i++)
                {
                    pole[i] = _teamList[i].Name;
                }

                Array.Sort(pole);

                Team teamH;
                List<Team> usporiadanyZoznam = new List<Team>();
                for (int i = 0; i < pocet; i++)
                {
                    teamH = null;
                    foreach (Team t in TeamList)
                    {
                        if (t.Name.Equals(pole[i]))
                            teamH = t;
                    }
                    TeamList.Remove(teamH);
                    usporiadanyZoznam.Add(teamH);
                }

                TeamList = usporiadanyZoznam;
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
                MessageBox.Show(@"Team was not added! Each team can be added only once! Define at least Team Name!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Player not found", "Remove team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
