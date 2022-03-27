using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Scoreboard.Classes.Database;
using Scoreboard.Forms.AppSettings;

namespace Scoreboard.Forms.Statistics;

public partial class SetPenaltyForm : Form
{
    private readonly SetTimes _times;
    private readonly List<Player> _players;

    public int[] Penalty { get; }

    public SetPenaltyForm(SetTimes parTimes,List<Player> parPlayers )
    {
        _times = parTimes;

        InitializeComponent();

        penaltyTimesCombo.Items.Add("Short penalty");
        penaltyTimesCombo.Items.Add("Long penalty");

        _players = parPlayers;
        selectPlayer.DataSource = _players;


        Penalty = new int[3];

        MaximizeBox = false;
        ControlBox = false;
    }

    private void SavePenaltyBtnClick(object parSender, EventArgs parE)
    {
        Penalty[0] = (int)playerNumber.Value;
        Penalty[1] = (int)pMinutes.Value;
        Penalty[2] = (int) pSeconds.Value;
        DialogResult = DialogResult.OK;
        Dispose();
    }

    private void CancelBtnClick(object parSender, EventArgs parE)
    {
        Dispose();
    }

    private void PenaltyTimesComboSelectedIndexChanged(object parSender, EventArgs parE)
    {
        if(_times == null) return;
        switch (penaltyTimesCombo.Text)
        {
            case @"Short penalty":
                pMinutes.Value = _times.ShortPenaltyLength.Minutes;
                pSeconds.Value = _times.ShortPenaltyLength.Seconds;
                break;
            case @"Long penalty":
                pMinutes.Value = _times.LongPenaltyLength.Minutes;
                pSeconds.Value = _times.LongPenaltyLength.Seconds;
                break;
        }
    }

    private void SelectPlayerSelectedIndexChanged(object parSender, EventArgs parE)
    {
        if (_players == null) return;
        var help = (Player) selectPlayer.SelectedItem;
        playerNumber.Value = string.IsNullOrWhiteSpace(selectPlayer.Text) ? 1 : decimal.Parse(help.Number);
    }
}