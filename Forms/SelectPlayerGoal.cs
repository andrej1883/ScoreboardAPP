using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scoreboard.Classes;
using Scoreboard.Classes.Database;
using Scoreboard.Classes.GameStatistics;

namespace Scoreboard.Forms
{
    public partial class SelectPlayerGoal : Form
    {
        private Time _time;
        private int _team;
        private MatchStatistics _stats;
        private List<Player> _players;

        public SelectPlayerGoal(int parTeam,MatchStatistics parStats,List<Player> parPlayers, Time parTime)
        {
            _time = parTime;
            _stats = parStats;
            _team = parTeam;
            _players = parPlayers;
            InitializeComponent();
            var empty = new Player() {Name = " ", Number = " "};
            _players.Add(empty);
            playerGoal.DataSource = _players;
            playerA1.BindingContext = new BindingContext();
            playerA1.DataSource = _players;
            playerA2.BindingContext = new BindingContext();
            playerA2.DataSource = _players;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveGoalBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(playerGoal.Text)) return;
            Player pGoal = (Player)playerGoal.SelectedItem;
            Player pAsist1 = (Player)playerA1.SelectedItem;
            Player pAsist2 = (Player)playerA2.SelectedItem;
            if(pGoal.Name == pAsist1.Name || pGoal.Name == pAsist2.Name)return;
            if (!String.IsNullOrWhiteSpace(pAsist1.Name) && String.Equals(pAsist1.Name, pAsist2.Name)) return;
            
            _stats.CreateGoalEvent(_team,pGoal,pAsist1,pAsist2,_time);
            Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
