using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Scoreboard.Classes;
using Scoreboard.Classes.Database;
using Scoreboard.Classes.GameStatistics;

namespace Scoreboard.Forms.Statistics;

// form used for selecting player and his assistance after goal was shot
public partial class SelectPlayerGoal : Form
{
    private readonly Time _time;
    private readonly int _team;
    private readonly MatchStatistics _stats;

    public SelectPlayerGoal(int parTeam,MatchStatistics parStats,List<Player> parPlayers, Time parTime)
    {
        if (parPlayers.Count == 0)
            throw new ArgumentException(@"Value cannot be an empty collection.", nameof(parPlayers));
        _time = parTime;
        _stats = parStats;
        _team = parTeam;
        InitializeComponent();
            
        playerGoal.DataSource = parPlayers;
        playerA1.BindingContext = new BindingContext();
        playerA1.DataSource = parPlayers;
        playerA2.BindingContext = new BindingContext();
        playerA2.DataSource = parPlayers;

        MaximizeBox = false;
        ControlBox = false;
    }

    private void SaveGoalBtnClick(object parSender, EventArgs parE)
    {
        if (string.IsNullOrWhiteSpace(playerGoal.Text)) return;
        var pGoal = (Player)playerGoal.SelectedItem;
        var pAsist1 = (Player)playerA1.SelectedItem;
        var pAsist2 = (Player)playerA2.SelectedItem;
        if(pGoal.Name == pAsist1.Name || pGoal.Name == pAsist2.Name)return;
        if (!string.IsNullOrWhiteSpace(pAsist1.Name) && string.Equals(pAsist1.Name, pAsist2.Name)) return;
            
        _stats.CreateGoalEvent(_team,pGoal,pAsist1,pAsist2,_time);
        Dispose();
    }

    private void CancelBtnClick(object parSender, EventArgs parE)
    {
        Dispose();
    }
}