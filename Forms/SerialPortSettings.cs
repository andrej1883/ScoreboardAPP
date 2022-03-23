using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scoreboard.Classes.AuxiliaryDevices;

namespace Scoreboard.Forms
{
    public partial class SerialPortSettings : Form
    {
        private CommunicationController _comControll;
        public SerialPortSettings()
        {
            InitializeComponent();
            _comControll = new CommunicationController();
        }

        private void SerialPortSettings_Load(object sender, EventArgs e)
        {
            activePorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void connectToPort_Click(object sender, EventArgs e)
        {
            var port = activePorts.Text;
            if (String.IsNullOrWhiteSpace(port)) return;
            _comControll.NastavCOMport(port);
            if (_comControll.StartBroadcast()) connectStatus.Text = "Connected";
        }

        private void disconnectPort_Click(object sender, EventArgs e)
        {
            if (_comControll.StopBroadcast()) connectStatus.Text = "Disconnected";
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            _comControll.SirenStart(SirenType.DISRUPTED);
        }
    }
}
