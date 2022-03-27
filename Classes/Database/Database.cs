using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scoreboard.Classes.Database;

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
        return _teamList.FirstOrDefault(parT => parT.Name.Equals(parTeamName));
    }

    public Advertisement FindAdv(string parAdvPath)
    {
        return _advList.FirstOrDefault(parA => parA.Path.Equals(parAdvPath));
    }

    public void OrderAfterLoad()
    {
        var teamCount = _teamList.Count;
        if (teamCount <= 0) return;
        var teamNames = new string[teamCount];
        for (var i = 0; i < teamCount; i++)
        {
            teamNames[i] = _teamList[i].Name;
        }

        Array.Sort(teamNames);

        List<Team> sortedTeams = new();
        for (var i = 0; i < teamCount; i++)
        {
            Team teamH = null;
            foreach (var t in TeamList.Where(parT => parT.Name.Equals(teamNames[i])))
            {
                teamH = t;
            }
            TeamList.Remove(teamH);
            sortedTeams.Add(teamH);
        }
        TeamList = sortedTeams;
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