using System.IO.Ports;
using System.Threading;

namespace Scoreboard.Classes.AuxiliaryDevices;

public class CommunicationController
{
    private const byte STX = 2;
    private const byte ETX = 3;
    private const byte sirenAddr = 100;
    private const int MaxAttempts = 5;
    private const int WaitingTime = 5000;

    private SerialPort _commPort;
    private bool _isOpenPort;
    private int _portNumber;

    private void NastavCOMport(int parPortNumber)
    {
        if (_portNumber != parPortNumber)
        {
            bool wasOpen = _isOpenPort;
            StopBroadcast();

            _portNumber = parPortNumber;
            _commPort.PortName = "COM" + _portNumber.ToString();

            if (wasOpen)
                StartBroadcast();
        }
    }

    private void StartBroadcast()
    {
        _isOpenPort = true;
        try
        {
            _commPort.Open();
        }
        catch
        {
            _isOpenPort = false;
        }
    }

    private void StopBroadcast()
    {
        _isOpenPort = false;
        try
        {
            if (_commPort.IsOpen)
                _commPort.Close();
        }
        catch
        {
            _isOpenPort = true;
        }
    }

    private byte getCheckSum(byte[] parPacket)
    {
        byte checkSum = 0;

        for (int i = 0; i < parPacket.Length - 1; i++)
        {
            checkSum ^= parPacket[i];
        }

        return checkSum;
    }

    private void SendMessage3x(byte[] parMessage)
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

    private SirenType getSirenType(int index)
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

    private void SirenStart(SirenType parType)
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
    }
}