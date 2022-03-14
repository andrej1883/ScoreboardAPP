using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scoreboard.Classes;

namespace Scoreboard.Forms
{
    public partial class SetTimes : Form
    {
        private Time _periodLength = new Time() {Minutes = 20, Seconds = 0};
        private Time _breakLength = new Time() {Minutes = 15, Seconds = 0};
        private Time _timeoutLength = new Time() {Minutes = 1, Seconds = 0};
        private Time _shortPenaltyLength = new Time() {Minutes = 2, Seconds = 0};
        private Time _longPenaltyLength = new Time() {Minutes = 5, Seconds = 0};
        private Time _preMatchTime = new Time() {Minutes = 10, Seconds = 0};
        private GameForm _parentForm;

        public Time PeriodLength
        {
            get => _periodLength;
            set => _periodLength = value;
        }

        public Time BreakLength
        {
            get => _breakLength;
            set => _breakLength = value;
        }

        public Time TimeoutLength
        {
            get => _timeoutLength;
            set => _timeoutLength = value;
        }

        public Time ShortPenaltyLength
        {
            get => _shortPenaltyLength;
            set => _shortPenaltyLength = value;
        }

        public Time LongPenaltyLength
        {
            get => _longPenaltyLength;
            set => _longPenaltyLength = value;
        }

        public Time PreMatchTime
        {
            get => _preMatchTime;
            set => _preMatchTime = value;
        }

        public SetTimes(GameForm parForm)
        {
            _parentForm = parForm;
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
            MaximizeBox = false;
            ControlBox = false;
            
        }

        private void SetTimes_Load(object sender, EventArgs e)
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
        }

        private void saveTimes_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show(@"This option will reset gameboard timers! Do you want to continue?" , @"Adjust timers length", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mess == DialogResult.Yes)
            {
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
                _parentForm.SetTime(_periodLength.Minutes,PeriodLength.Seconds);
                _parentForm.SetTimeoutLength(1,_timeoutLength.Minutes,_timeoutLength.Seconds);
                _parentForm.SetTimeoutLength(2,_timeoutLength.Minutes,_timeoutLength.Seconds);
                _parentForm.InitBoards();
                Hide();
            }
        }

        private void cancelEditTimes_Click(object sender, EventArgs e)
        {
            _parentForm.InitBoards();
            Hide();
        }

        private void CheckNumbers()
        {
            foreach (NumericUpDown upDown in Controls.OfType<NumericUpDown>())
            {
                if (String.IsNullOrWhiteSpace(upDown.Text))
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
}
