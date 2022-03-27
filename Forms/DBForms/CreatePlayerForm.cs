using System;
using System.Windows.Forms;
using Scoreboard.Classes.Database;

namespace Scoreboard.Forms.DBForms;

public partial class CreatePlayerForm : Form
{
    private readonly Team _team;

    public CreatePlayerForm(Team parTeam)
    {
        InitializeComponent();
        _team = parTeam;
        MaximizeBox = false;
    }

    private void CreatePlayerFormLoad(object parSender, EventArgs parE)
    {
        UpdateGv();
    }

    private void UpdateGv()
    {
        PLayersGW.DataSource = null;
        PLayersGW.BindingContext = new BindingContext();
        PLayersGW.DataSource = _team.Players;
        PLayersGW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        PLayersGW.Update();
    }

    private void AddPlayerClick(object parSender, EventArgs parE)
    {
        Player help = new() {Name = PlayerName.Text, Number = PlayerNumber.Text};
        _team.Players.Add(help);
        UpdateGv();
        PlayerName.Clear();
        PlayerNumber.Clear();
    }

    private void RemovePlayerClick(object parSender, EventArgs parE)
    {
        if (PLayersGW.SelectedRows.Count <= 0) return;
        _team.Players.Remove((Player)PLayersGW.SelectedRows[0].DataBoundItem);
        UpdateGv();
    }

    private void OkClick(object parSender, EventArgs parE)
    {
        Dispose();
    }
}