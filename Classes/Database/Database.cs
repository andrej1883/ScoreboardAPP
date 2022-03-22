using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scoreboard.Classes.Database
{
    [Serializable]
    public class Database
    {
        private List<Team> _teamList;
        private List<Advertisment> _advList;


        public List<Advertisment> AdvList
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
            _advList = new List<Advertisment>();

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

        public Advertisment FindAdv(string parAdvPath)
        {
            foreach (Advertisment a in _advList)
            {
                if (a.Path.Equals(parAdvPath))
                    return a;
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

        public void AddAdv(Advertisment parVid)
        {

            if (!_advList.Contains(parVid) && FindAdv(parVid.Path) == null && parVid.Path.Length > 0)
            {
                _advList.Add(parVid);
            }
            else
            {
                MessageBox.Show(@"Video was not added! Each video can be added only once! Define at least Video path!" , @"Add adv Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveAdv(Advertisment parVid)
        {
            if (_advList.Contains(parVid))
            {
                _advList.Remove(parVid);
            }
            else
            {
                MessageBox.Show("Video not found", "Remove adv Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
