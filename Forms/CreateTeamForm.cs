using System;
using System.Windows.Forms;
using Scoreboard.Classes;

namespace Scoreboard.Forms
{
    public partial class CreateTeamForm : Form
    {
        private Team _team;

        public Team Team
        {
            get => _team;
            set => _team = value;
        }

        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            _team = new Team();
            _team.Name = TeamName.Text;
            _team.VideoPath = VideoPath.Text;
            _team.LogoPath = LogoPath.Text;
            Dispose();
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Video Files(*.mp4)|*.mp4";  
            if (open.ShowDialog() == DialogResult.OK) {

                VideoPath.Text = open.FileName;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SelectPathLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";   
            if (open.ShowDialog() == DialogResult.OK) {

                LogoPath.Text = open.FileName;
            }
        }
    }
}
