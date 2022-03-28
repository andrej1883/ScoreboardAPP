using System;
using System.Windows.Forms;

namespace Scoreboard.Forms.Statistics;

// form used for creating manual event for more info check classes -> GameStatistics -> MatchStatistics
public partial class ManualEvent : Form
{
    private string _eventName;
    private string _description;

    public string EventName
    {
        get => _eventName;
        set => _eventName = value;
    }
    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public ManualEvent()
    {
        InitializeComponent();
        MaximizeBox = false;
    }

    private void ConfirmBtnClick(object sender, EventArgs e)
    {
        _eventName = eventName.Text;
        _description = eventDescription.Text;
        DialogResult = DialogResult.OK;
        Dispose();
    }

    private void CancelBtnClick(object sender, EventArgs e)
    {
        Dispose();
    }
}