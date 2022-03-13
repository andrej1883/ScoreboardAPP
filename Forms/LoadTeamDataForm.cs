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

        public Database Database
        {
            get => _database;
            set => _database = value;
        }

        public LoadTeamDataForm()
        {
            InitializeComponent();
            if (_database == null)
            {
                _database = new Database();
            }
            UpdateGv();
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
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "xml files (*.xml)|*.xml";
                open.InitialDirectory = Environment.CurrentDirectory+ "\\DB";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Database));
                    textReader = new StreamReader(open.FileName);
                    _database = (Database)deserializer.Deserialize(textReader);
                }
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

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory+ "\\DB";
            TextWriter textWriter = null;

            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Database));
                    textWriter = new StreamWriter(saveFileDialog1.FileName);
                    serializer.Serialize(textWriter, _database);

                }
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

        private void LoadTeamDataForm_Load(object sender, EventArgs e)
        {
            UpdateGv();
        }
    }
}
