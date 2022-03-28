using System;
using System.Windows.Forms;

namespace Scoreboard.Forms.Statistics;

// form used for creating manual event for more info check classes -> GameStatistics -> MatchStatistics
public partial class ManualEvent : Form
{
    public string EventName { get; private set; }

    public string Description { get; private set; }

    public ManualEvent()
    {
        InitializeComponent();
        MaximizeBox = false;
    }

    private void ConfirmBtnClick(object parSender, EventArgs parE)
    {
        EventName = eventName.Text;
        Description = eventDescription.Text;
        DialogResult = DialogResult.OK;
        Dispose();
    }

    private void CancelBtnClick(object parSender, EventArgs parE)
    {
        Dispose();
    }
}