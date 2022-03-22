using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Scoreboard.Classes.Database;
using Scoreboard.Forms.AppSettings;

namespace Scoreboard.Forms.Statistics
{
    public partial class SetPenaltyForm : Form
    {
        private SetTimes _times;
        private List<Player> _players;
        private int[] _penalty;

        public int[] Penalty
        {
            get => _penalty;
            set => _penalty = value;
        }

        public SetPenaltyForm(SetTimes parTimes,List<Player> parPlayers )
        {
            _times = parTimes;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            penaltyTimesCombo.Items.Add("Short penalty");
            penaltyTimesCombo.Items.Add("Long penalty");

            _players = parPlayers;
            selectPlayer.DataSource = _players;


            _penalty = new int[3];
        }

        private void savePenaltyBtn_Click(object sender, EventArgs e)
        {
            _penalty[0] = (int)playerNumber.Value;
            _penalty[1] = (int)pMinutes.Value;
            _penalty[2] = (int) pSeconds.Value;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void penaltyTimesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_times == null) return;
            if (penaltyTimesCombo.Text == "Short penalty")
            {
                pMinutes.Value = _times.ShortPenaltyLength.Minutes;
                pSeconds.Value = _times.ShortPenaltyLength.Seconds;
            } else if (penaltyTimesCombo.Text == "Long penalty")
            {
                pMinutes.Value = _times.LongPenaltyLength.Minutes;
                pSeconds.Value = _times.LongPenaltyLength.Seconds;
            }

        }

        private void selectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_players == null) return;
            var help = (Player) selectPlayer.SelectedItem;
            playerNumber.Value = Decimal.Parse(help.Number);

        }

    }
}
