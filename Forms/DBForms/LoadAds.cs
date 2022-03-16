using System;
using System.Windows.Forms;
using Scoreboard.Classes.Database;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms.DBForms
{
    public partial class LoadAds : Form
    {
        private Database _database;
        private GameForm _pareGameForm;

        public Database Database
        {
            get => _database;
            set => _database = value;
        }

        public LoadAds(GameForm parGameForm)
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
        

        private void addVideo_Click(object sender, EventArgs e)
        {
            string path = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Video Files(*.mp4)|*.mp4";  
            open.InitialDirectory = Environment.CurrentDirectory+ "\\Videos\\Ads";
            if (open.ShowDialog() == DialogResult.OK) 
            {
                path = open.FileName;
                var help = new Advertisment() {Path = path};
                _database.AddAdv(help);
                UpdateGv();
            }
        }

        private void removeVideo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _database.RemoveAdv((Advertisment)dataGridView1.SelectedRows[0].DataBoundItem);
                UpdateGv();
            }
        }


        private void done_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UpdateGv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.BindingContext = new BindingContext();
            dataGridView1.DataSource = _database.AdvList;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Update();
            _pareGameForm.UpdateAds(_database);
        }
    }
}
