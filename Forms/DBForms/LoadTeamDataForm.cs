using System;
using System.Windows.Forms;
using Scoreboard.Classes.Database;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms.DBForms;

// form used for editing teams in DB 
// teams can be added / removed / deleted / edited
// user can also edit players in teams, after selecting team and clicking edit players form with players is displayed 
// team data is displayed in Grid view and also can be edited there
public partial class LoadTeamDataForm : Form
{
    private readonly GameForm _pareGameForm;

    public Database Database { get; }

    public LoadTeamDataForm(GameForm parGameForm)
    {
        _pareGameForm = parGameForm;
        Database = _pareGameForm.DatabaseGame;
        InitializeComponent();
        Database ??= new Database();
        UpdateGv();
        MaximizeBox = false;
    }

    private void AddTeamClick(object parSender, EventArgs parE)
    {
        var add = new CreateTeamForm();
        add.ShowDialog();

        var help = add.Team;
        if (help == null) return;
        Database.AddTeam(help);
        UpdateGv();
    }

    private void RemoveTeamClick(object parSender, EventArgs parE)
    {
        if (dataGridView1.SelectedRows.Count <= 0) return;
        Database.RemoveTeam((Team)dataGridView1.SelectedRows[0].DataBoundItem);
        UpdateGv();
    }

    private void UpdateGv()
    {
        dataGridView1.DataSource = null;
        dataGridView1.BindingContext = new BindingContext();
        dataGridView1.DataSource = Database.TeamList;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Update();
        _pareGameForm.UpdateTeams(Database);
    }

    private void EditTeamPlayersClick(object parSender, EventArgs parE)
    {
        if (dataGridView1.SelectedRows.Count <= 0 || Database.TeamList.Count <= 0) return;
        var plaForm = new CreatePlayerForm((Team)dataGridView1.SelectedRows[0].DataBoundItem);
        plaForm.ShowDialog();
        UpdateGv();
    }

    private void OkClick(object parSender, EventArgs parE)
    {
        Dispose();
    }
}