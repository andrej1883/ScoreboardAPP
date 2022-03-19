using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard.Forms
{
    public partial class SetPenaltyForm : Form
    {

        public SetPenaltyForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            penaltyTimesCombo.Items.Add("Short penalty");
            penaltyTimesCombo.Items.Add("Long penalty");
        }

        private void savePenaltyBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void penaltyTimesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (penaltyTimesCombo.Text == "Short penalty")
            {
                pMinutes.Value = 2;
                pSeconds.Value = 0;
            } else if (penaltyTimesCombo.Text == "Long penalty")
            {
                pMinutes.Value = 5;
                pSeconds.Value = 0;
            }

        }
    }
}
