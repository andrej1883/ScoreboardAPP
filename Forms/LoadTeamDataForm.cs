using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes;

namespace Scoreboard.Forms
{
    public partial class LoadTeamDataForm : Form
    {
        private Database _database;
        private GameForm _pareGameForm;

        public Database Database
        {
            get => _database;
            set => _database = value;
        }

        public LoadTeamDataForm(GameForm parGameForm)
        {
            _pareGameForm = parGameForm;
            _database = _pareGameForm.DatabaseGame;
            InitializeComponent();
            if (_database == null)
            {
                _database = new Database();
            }
            UpdateGv();
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var add = new CreateTeamForm();
            add.ShowDialog();

            Team help = add.Team;
            if (help != null)
            {
                _database.AddTeam(help);
                UpdateGv();
            }
        }

        private void RemoveTeam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _database.RemoveTeam((Team)dataGridView1.SelectedRows[0].DataBoundItem);
                UpdateGv();
            }
        }

        private void UpdateGv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _database.TeamList;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Update();
            _pareGameForm.UpdateTeams(_database);
        }

        private void EditTeamPlayers_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && _database.TeamList.Count > 0)
            {
                var plaForm = new CreatePlayerForm((Team)dataGridView1.SelectedRows[0].DataBoundItem);
                plaForm.ShowDialog();
                UpdateGv();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
