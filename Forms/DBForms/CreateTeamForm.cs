using System;
using System.Windows.Forms;
using Scoreboard.Classes.Database;

namespace Scoreboard.Forms.DBForms;

public partial class CreateTeamForm : Form
{
    public Team Team { get; private set; }

    public CreateTeamForm()
    {
        InitializeComponent();
        MaximizeBox = false;
    }

    private void CreateClick(object parSender, EventArgs parE)
    {
        if (string.IsNullOrWhiteSpace(TeamName.Text)) return;
        Team = new Team
        {
            Name = TeamName.Text,
            VideoPath = VideoPath.Text,
            LogoPath = LogoPath.Text
        };
        Dispose();
    }

    private void SelectPathClick(object parSender, EventArgs parE)
    {
        OpenFileDialog open = new();
        open.Filter = @"Video Files(*.mp4)|*.mp4";
        open.InitialDirectory = $"{Environment.CurrentDirectory}\\Videos\\Intro";
        if (open.ShowDialog() == DialogResult.OK)
        {
            VideoPath.Text = open.FileName;
        }
    }

    private void CancelClick(object parSender, EventArgs parE)
    {
        Dispose();
    }

    private void SelectPathLogoClick(object parSender, EventArgs parE)
    {
        OpenFileDialog open = new();
        open.Filter = @"Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        if (open.ShowDialog() == DialogResult.OK)
        {
            LogoPath.Text = open.FileName;
        }
    }
}