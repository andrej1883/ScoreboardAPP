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
        private int _breakLenght = 15;
        private int _timeoutLength = 1;
        private int _shortPenaltyLenght = 2;
        private int _longPenaltyLength = 5;
        private int _prematchTime = 10;
        private GameForm _parentForm;

        public Time PeriodLength
        {
            get => _periodLength;
            set => _periodLength = value;
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
            breakLInputM.Value = _breakLenght;
            timeoutLInputM.Value = _timeoutLength;
            shortPenaltyInputM.Value = _shortPenaltyLenght;
            longPenaltyInputM.Value = _longPenaltyLength;
            preMatchInputM.Value = _prematchTime;
        }

        private void saveTimes_Click(object sender, EventArgs e)
        {
            if (periodLInputM.Value > 0)_periodLength.Minutes = (int)periodLInputM.Value;
            if (breakLInputM.Value > 0)_breakLenght = (int)breakLInputM.Value;
            if (timeoutLInputM.Value > 0)_timeoutLength = (int)timeoutLInputM.Value;
            if (shortPenaltyInputM.Value > 0)_shortPenaltyLenght = (int)shortPenaltyInputM.Value;
            if (longPenaltyInputM.Value > 0)_longPenaltyLength = (int)longPenaltyInputM.Value;
            if (preMatchInputM.Value > 0)_prematchTime = (int)preMatchInputM.Value;
            _parentForm.SetTime(_periodLength.Minutes,PeriodLength.Seconds);
            _parentForm.InitBoards();
            Hide();
        }

        private void cancelEditTimes_Click(object sender, EventArgs e)
        {
            _parentForm.InitBoards();
            Hide();
        }
    }
}
