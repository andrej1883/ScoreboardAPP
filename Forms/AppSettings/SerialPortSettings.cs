using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Scoreboard.Classes.AuxiliaryDevices;
using static System.IO.Ports.SerialPort;

namespace Scoreboard.Forms.AppSettings;

public partial class SerialPortSettings : Form
{
    private const byte Stx = 2;
    private const byte Etx = 3;
    private const int MessageCount = 1;
    private const int WaitingTime = 1;

    private readonly SerialPort _commPort;


    public SerialPortSettings()
    {
        InitializeComponent();
        _commPort = new SerialPort();
        MaximizeBox = false;
        ControlBox = false;
    }

    private void SerialPortSettingsLoad(object parSender, EventArgs parE)
    {
        var ports = GetPortNames();
        foreach (var port in ports)
            activePorts.Items.Add(port);
        disconnectPort.Enabled = false;
            

            
    }

    private void ConnectToPortClick(object parSender, EventArgs parE)
    {
        try
        {
            _commPort.PortName = activePorts.Text;
            _commPort.Open();
            if (!_commPort.IsOpen) return;
            disconnectPort.Enabled = true;
            connectToPort.Enabled = false;
            connectStatus.Text = $@"Connected to: {_commPort.PortName}";
            activePorts.Enabled = false;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, @"Connect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DisconnectPortClick(object parSender, EventArgs parE)
    {
        try
        {
            _commPort.Close();
            if (_commPort.IsOpen) return;
            disconnectPort.Enabled = false;
            connectToPort.Enabled = true;
            connectStatus.Text = @"Disconnected";
            activePorts.Enabled = true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, @"Disconnect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static byte GetCheckSum(byte[] parPacket)
    {
        if (parPacket.Length == 0)
            throw new ArgumentException(@"Value cannot be an empty collection.", nameof(parPacket));
        byte checkSum = 0;

        for (var i = 0; i < parPacket.Length - 1; i++) checkSum ^= parPacket[i];

        return checkSum;
    }

    private void SendMessage(byte[] parMessage)
    {
        if (!_commPort.IsOpen) return;
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
        byte[] byteArray;

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

    private void ConfirmBtnClick(object parSender, EventArgs parE)
    {
        Hide();
    }

    private void CancelBtnClick(object parSender, EventArgs parE)
    {
        if (_commPort.IsOpen)
        {
            _commPort.Close();
        }
        Dispose();
    }
}