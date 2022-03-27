using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scoreboard.Classes.AuxiliaryDevices;

namespace Scoreboard.Forms
{
    public partial class SerialPortSettings : Form
    {
        private const byte Stx = 2;
        private const byte Etx = 3;
        private const int MessageCount = 1;
        private const int WaitingTime = 1;

        private SerialPort _commPort;


        public SerialPortSettings()
        {
            InitializeComponent();
            _commPort = new SerialPort();
            MaximizeBox = false;
            ControlBox = false;
        }

        private void SerialPortSettings_Load(object sender, EventArgs e)
        {
            activePorts.Items.AddRange(SerialPort.GetPortNames());
            disconnectPort.Enabled = false;
        }

        private void connectToPort_Click(object sender, EventArgs e)
        {
            try
            {
                _commPort.PortName = activePorts.Text;
                _commPort.Open();
                if (_commPort.IsOpen)
                {
                    disconnectPort.Enabled = true;
                    connectToPort.Enabled = false;
                    connectStatus.Text = "Connected to: " + _commPort.PortName;
                    activePorts.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Connect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectPort_Click(object sender, EventArgs e)
        {
            try
            {
                _commPort.Close();
                if (!_commPort.IsOpen)
                {
                    disconnectPort.Enabled = false;
                    connectToPort.Enabled = true;
                    connectStatus.Text = "Disconnected";
                    activePorts.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Disconnect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte GetCheckSum(byte[] parPacket)
        {
            byte checkSum = 0;

            for (var i = 0; i < parPacket.Length - 1; i++) checkSum ^= parPacket[i];

            return checkSum;
        }

        private void SendMessage(byte[] parMessage)
        {
            if (_commPort.IsOpen)
                for (var i = 0; i < MessageCount; i++)
                {
                    _commPort.ReadTimeout = WaitingTime;
                    _commPort.DiscardInBuffer();
                    _commPort.Write(parMessage, 0, parMessage.Length);

                    if (i < MessageCount - 1) Thread.Sleep(WaitingTime);
                }
        }

        public void SirenStart(SirenType parType)
        {
            byte[] byteArray = null;

            switch (parType)
            {
                case SirenType.Short:
                    byteArray = new byte[5];
                    byteArray[0] = Stx;
                    byteArray[1] = (byte) 'S';
                    byteArray[2] = (byte) '3';
                    byteArray[3] = Etx;
                    break;

                case SirenType.Normal:
                    byteArray = new byte[5];
                    byteArray[0] = Stx;
                    byteArray[1] = (byte) 'S';
                    byteArray[2] = (byte) '1';
                    byteArray[3] = Etx;
                    break;

                case SirenType.Long:
                    byteArray = new byte[5];
                    byteArray[0] = Stx;
                    byteArray[1] = (byte) 'S';
                    byteArray[2] = (byte) '2';
                    byteArray[3] = Etx;
                    break;

                case SirenType.Disrupted:
                    byteArray = new byte[5];
                    byteArray[0] = Stx;
                    byteArray[1] = (byte) 'S';
                    byteArray[2] = (byte) '5';
                    byteArray[3] = Etx;
                    break;

                default:
                    return;
            }

            byteArray[byteArray.Length - 1] = GetCheckSum(byteArray);
            SendMessage(byteArray);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (_commPort.IsOpen)
            {
                _commPort.Close();
            }
            Dispose();
        }
    }
}
