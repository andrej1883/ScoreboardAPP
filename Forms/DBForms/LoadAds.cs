using System;
using System.Windows.Forms;
using Scoreboard.Classes.Database;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms.DBForms;

// form for editing advertisements in DB 
// add / remove operations are included by buttons
// add button shows dialog to select video file and saves path to video in DB
// edit is possible in grid view in which are data displayed
public partial class LoadAds : Form
{
    private readonly GameForm _pareGameForm;

    public Database Database { get; }

    public LoadAds(GameForm parGameForm)
    {
        _pareGameForm = parGameForm;
        Database = _pareGameForm.DatabaseGame;
        InitializeComponent();
        Database ??= new Database();
        UpdateGv();
        MaximizeBox = false;
    }
        
    private void AddVideoClick(object parSender, EventArgs parE)
    {
        OpenFileDialog open = new();
        open.Filter = @"Video Files(*.mp4)|*.mp4";  
        open.InitialDirectory = $"{Environment.CurrentDirectory}\\Videos\\Ads";
        if (open.ShowDialog() != DialogResult.OK) return;
        var path = open.FileName;
        var help = new Advertisement {Path = path};
        Database.AddAdv(help);
        UpdateGv();
    }

    private void RemoveVideoClick(object parSender, EventArgs parE)
    {
        if (dataGridView1.SelectedRows.Count <= 0) return;
        Database.RemoveAdv((Advertisement)dataGridView1.SelectedRows[0].DataBoundItem);
        UpdateGv();
    }

    private void DoneClick(object parSender, EventArgs parE)
    {
        Dispose();
    }

    private void UpdateGv()
    {
        dataGridView1.DataSource = null;
        dataGridView1.BindingContext = new BindingContext();
        dataGridView1.DataSource = Database.AdvList;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Update();
        _pareGameForm.UpdateAds(Database);
    }
}