using System;
using System.Windows.Forms;

namespace Scoreboard.Forms.AppSettings
{
    public partial class StatisticsSettings : Form
    {
        private bool[] _activeStatistics;

        public bool[] ActiveStatistics
        {
            get => _activeStatistics;
            set => _activeStatistics = value;
        }

        public StatisticsSettings()
        {
            _activeStatistics = new bool[3];
            for (int i = 0; i < _activeStatistics.Length; i++)
            {
                _activeStatistics[i] = true;
            }
            InitializeComponent();
            MaximizeBox = false;
            ControlBox = false;
        }

        private void timeoutsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!timeoutsBox.Checked)
            {
                _activeStatistics[0] = false;
            }
            else
            {
                _activeStatistics[0] = true;
            }
        }

        private void faceOffsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!faceOffsBox.Checked)
            {
                _activeStatistics[1] = false;
            }
            else
            {
                _activeStatistics[1] = true;
            }
        }

        private void shotsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!shotsBox.Checked)
            {
                _activeStatistics[2] = false;
            }
            else
            {
                _activeStatistics[2] = true;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
