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
    public partial class ManualEvent : Form
    {
        private string _name;
        private string _description;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public ManualEvent()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            _name = eventName.Text;
            _description = eventDescription.Text;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
