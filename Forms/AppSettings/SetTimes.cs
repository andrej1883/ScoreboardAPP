using System;
using System.Linq;
using System.Windows.Forms;
using Scoreboard.Classes;
using Scoreboard.Forms.MainGameForms;

namespace Scoreboard.Forms.AppSettings;

public partial class SetTimes : Form
{
    private Time _periodLength = new() {Minutes = 3, Seconds = 0};
    private Time _breakLength = new() {Minutes = 0, Seconds = 15};
    private Time _timeoutLength = new() {Minutes = 0, Seconds = 10};
    private Time _shortPenaltyLength = new() {Minutes = 2, Seconds = 0};
    private Time _longPenaltyLength = new() {Minutes = 5, Seconds = 0};
    private Time _preMatchTime = new() {Minutes = 0, Seconds = 5};
    private Time _periodOvertLength = new() {Minutes = 10, Seconds = 0};
    private Time _breakOvertLength = new() {Minutes = 5, Seconds = 0};
    private readonly GameForm _parentForm;

    public Time PeriodLength => _periodLength;

    public Time PeriodOvertLength => _periodOvertLength;

    public Time BreakOvertLength => _breakOvertLength;

    public Time BreakLength => _breakLength;

    public Time TimeoutLength => _timeoutLength;

    public Time ShortPenaltyLength => _shortPenaltyLength;

    public Time LongPenaltyLength => _longPenaltyLength;

    public Time PreMatchTime => _preMatchTime;

    public SetTimes(GameForm parForm)
    {
        _parentForm = parForm;
        InitializeComponent();
        MaximizeBox = false;
        ControlBox = false;
            
    }

    private void SetTimesLoad(object parSender, EventArgs parE)
    {
        periodLInputM.Value = _periodLength.Minutes;
        periodLInputS.Value = _periodLength.Seconds;
        breakLInputM.Value = _breakLength.Minutes;
        breakLInputS.Value = _breakLength.Seconds;
        timeoutLInputM.Value = _timeoutLength.Minutes;
        timeoutLInputS.Value = _timeoutLength.Seconds;
        shortPenaltyInputM.Value = _shortPenaltyLength.Minutes;
        shortPenaltyInputS.Value = _shortPenaltyLength.Seconds;
        longPenaltyInputM.Value = _longPenaltyLength.Minutes;
        longPenaltyInputS.Value = _longPenaltyLength.Seconds;
        preMatchInputM.Value = _preMatchTime.Minutes;
        preMatchInputS.Value = _preMatchTime.Seconds;
        overPeriodLM.Value = _periodOvertLength.Minutes;
        overPeriodLS.Value = _periodOvertLength.Seconds;
        overBreakLM.Value = _breakOvertLength.Minutes;
        overBreakLS.Value = _breakOvertLength.Seconds;
    }

    private void SaveTimesClick(object parSender, EventArgs parE)
    {
        var mess = MessageBox.Show(@"This option will reset game-board timers! Do you want to continue?" , @"Adjust timers length", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (mess != DialogResult.Yes) return;
        CheckNumbers();
        _periodLength.Minutes = (int)periodLInputM.Value;
        _periodLength.Seconds = (int)periodLInputS.Value;
        _breakLength.Minutes = (int)breakLInputM.Value;
        _breakLength.Seconds = (int)breakLInputS.Value;
        _timeoutLength.Minutes = (int)timeoutLInputM.Value;
        _timeoutLength.Seconds = (int)timeoutLInputS.Value;
        _shortPenaltyLength.Minutes = (int)shortPenaltyInputM.Value;
        _shortPenaltyLength.Seconds = (int)shortPenaltyInputS.Value;
        _longPenaltyLength.Minutes = (int)longPenaltyInputM.Value;
        _longPenaltyLength.Seconds = (int)longPenaltyInputS.Value;
        _preMatchTime.Minutes = (int)preMatchInputM.Value;
        _preMatchTime.Seconds = (int)preMatchInputS.Value;
        _periodOvertLength.Minutes = (int)overPeriodLM.Value;
        _periodOvertLength.Seconds = (int)overPeriodLS.Value;
        _breakOvertLength.Minutes = (int)overBreakLM.Value;
        _breakOvertLength.Seconds = (int)overBreakLS.Value;
        _parentForm.SetTime(_periodLength);
        _parentForm.SetTimeoutLength(1,_timeoutLength);
        _parentForm.SetTimeoutLength(2,_timeoutLength);
        _parentForm.InitBoards();
        Hide();
    }

    private void CancelEditTimesClick(object parSender, EventArgs parE)
    {
        _parentForm.InitBoards();
        Hide();
    }

    private void CheckNumbers()
    {
        foreach (var upDown in Controls.OfType<NumericUpDown>())
        {
            if (string.IsNullOrWhiteSpace(upDown.Text))
            {
                upDown.Value = 0;
            }
            else if (upDown.Value > 59)
            {
                upDown.Value = 59;
            }
        }
    }
}