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

namespace Scoreboard.Forms
{
    public partial class CreatePlayerForm : Form
    {
        private Team _team;

        public CreatePlayerForm(Team parTeam)
        {
            InitializeComponent();
            _team = parTeam;
        }

        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            UpdateGv();
        }

        private void UpdateGv()
        {
            PLayersGW.DataSource = null;
            PLayersGW.DataSource = _team.Players;
            PLayersGW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PLayersGW.Update();
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            Player help = new Player() {Name = PlayerName.Text, Number = PlayerNumber.Text};
            _team.Players.Add(help);
            UpdateGv();
            PlayerName.Clear();
            PlayerNumber.Clear();
        }

        private void RemovePlayer_Click(object sender, EventArgs e)
        {
            if (PLayersGW.SelectedRows.Count > 0)
            {
                _team.Players.Remove((Player)PLayersGW.SelectedRows[0].DataBoundItem);
                UpdateGv();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
