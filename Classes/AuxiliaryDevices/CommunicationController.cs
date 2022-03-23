using System.IO.Ports;
using System.Threading;

namespace Scoreboard.Classes.AuxiliaryDevices;

public class CommunicationController
{
    private const byte STX = 2;
    private const byte ETX = 3;
    private const byte sirenAddr = 100;
    private const int MaxAttempts = 1;
    private const int WaitingTime = 1;

    private SerialPort _commPort;
    private bool _isOpenPort;
    private string _portNumber;

    public void NastavCOMport(string parPortNumber)
    {
        if (_portNumber != parPortNumber)
        {
            _commPort = new SerialPort(parPortNumber);
            bool wasOpen = _isOpenPort;
            StopBroadcast();

            _portNumber = parPortNumber;
            _commPort.PortName = _portNumber;

            if (wasOpen)
                StartBroadcast();
        }
    }

    public bool StartBroadcast()
    {
        _isOpenPort = true;
        try
        {
            _commPort.Open();
            return true;
        }
        catch
        {
            _isOpenPort = false;
            return false;
        }
    }

    public bool StopBroadcast()
    {
        _isOpenPort = false;
        try
        {
            if (_commPort.IsOpen)
                _commPort.Close();
            return true;
        }
        catch
        {
            _isOpenPort = true;
            return false;
        }
    }

    public byte getCheckSum(byte[] parPacket)
    {
        byte checkSum = 0;

        for (int i = 0; i < parPacket.Length - 1; i++)
        {
            checkSum ^= parPacket[i];
        }

        return checkSum;
    }

    public void SendMessage3x(byte[] parMessage)
    {
        if (!_isOpenPort)
            return;

        try
        {
            if (_commPort.IsOpen)
            {
                for (int i = 0; i < MaxAttempts; i++)
                {
                    // Posli spravu
                    _commPort.ReadTimeout = WaitingTime;
                    _commPort.DiscardInBuffer();
                    _commPort.Write(parMessage, 0, parMessage.Length);

                    if (i < MaxAttempts - 1)
                        Thread.Sleep(WaitingTime);
                }
            }
        }
        catch
        {
        }
    }

    public SirenType getSirenType(int index)
    {
        switch (index)
        {
            case 0:
                return SirenType.SHORT;
            case 1:
                return SirenType.NORMAL;
            case 2:
                return SirenType.LONG;
            case 3:
                return SirenType.DISRUPTED;
            default:
                return SirenType.NONE;
        }
    }

    public void SirenStart(SirenType parType)
    {
        if (parType == SirenType.NONE) return;

        byte[] byteArray = null;

        if (parType == SirenType.LONG)
        {
            byteArray = new byte[5];
            byteArray[0] = STX;
            byteArray[1] = (byte)'S';
            byteArray[2] = (byte)'2';
            byteArray[3] = ETX;
        }
        else if (parType == SirenType.NORMAL)
        {
            byteArray = new byte[5];
            byteArray[0] = STX;
            byteArray[1] = (byte)'S';
            byteArray[2] = (byte)'1';
            byteArray[3] = ETX;
        }
        else if (parType == SirenType.SHORT)
        {
            byteArray = new byte[5];
            byteArray[0] = STX;
            byteArray[1] = (byte)'S';
            byteArray[2] = (byte)'3';
            byteArray[3] = ETX;
        }
        else if (parType == SirenType.DISRUPTED)
        {
            byteArray = new byte[5];
            byteArray[0] = STX;
            byteArray[1] = (byte)'S';
            byteArray[2] = (byte)'5';
            byteArray[3] = ETX;
        }

        byteArray[byteArray.Length - 1] = getCheckSum(byteArray);
        SendMessage3x(byteArray);

        //byteArray = new byte[4];
        //byteArray[0] = (byte)'C';
        //byteArray[1] = (byte)'A';
        //byteArray[2] = (byte)'U';
        //byteArray[3] = ETX;
        //SendMessage3x(byteArray);
        //byteArray = new byte[3];
        //byteArray[0] = (byte)'1';
        //byteArray[1] = (byte)'A';
        //byteArray[2] = (byte)'2';
        //SendMessage3x(byteArray);
        //byteArray = new byte[3];
        //byteArray[0] = (byte)'1';
        //byteArray[1] = (byte)'2';
        //byteArray[2] = (byte)'3';
        //SendMessage3x(byteArray);
    }
}