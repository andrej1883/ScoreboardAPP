using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes;

namespace Scoreboard.Forms
{
    public partial class LoadTeamDataForm : Form
    {
        private Database _database;
        private string _dbPath = Environment.CurrentDirectory+ "\\db2.xml";

        public LoadTeamDataForm()
        {
            InitializeComponent();
            _database = new Database();
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            LoadDatabase();
            UpdateGv();
        }

        private void savedData_Click(object sender, EventArgs e)
        {
            SaveDatabase();
        }

        private void LoadDatabase()
        {
            TextReader textReader = null;
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Database));
                textReader = new StreamReader(_dbPath);
                _database = (Database)deserializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                _database = new Database();
                MessageBox.Show(ex.Message, "nazovProgramuString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textReader != null)
                    textReader.Close();
                _database.PostLoad();
            }
        }

        private void SaveDatabase()
        {
            TextWriter textWriter = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Database));
                textWriter = new StreamWriter(_dbPath);
                serializer.Serialize(textWriter, _database);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "nazovProgramuString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textWriter != null)
                    textWriter.Close();
            }
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
            else
            {
                MessageBox.Show("Team null error" , "Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
