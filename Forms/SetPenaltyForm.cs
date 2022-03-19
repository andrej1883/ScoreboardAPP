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
        }

        private void savePenaltyBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
