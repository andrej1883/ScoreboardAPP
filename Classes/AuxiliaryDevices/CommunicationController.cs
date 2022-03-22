using System.IO.Ports;
using System.Threading;

namespace Scoreboard.Classes.AuxiliaryDevices;

public class CommunicationController
{
    private const byte STX = 2;
    private const byte ETX = 3;
    private const byte pannelAddr = 100;
    private const int MaxAttempts = 5;
    private const int WaitingTime = 5000;

    private SerialPort _commPort;
    private bool _isOpenPort;
    private int _portNumber;

    private void NastavCOMport(int noveCisloPortu)
        {
            if (_portNumber != noveCisloPortu)
            {
                bool bolOtvorenyPort = _isOpenPort;
                ZastavVysielanie();

                _portNumber = noveCisloPortu;
                _commPort.PortName = "COM" + _portNumber.ToString();

                if (bolOtvorenyPort)
                    SpustiVysielanie();
            }
        }

private void SpustiVysielanie()
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

        private void ZastavVysielanie()
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


        #region Sireny

        private byte getCheckSum(byte[] paket)
        {
            // Pomocna metoda na vypocet kontrolnej sumy
            byte kontrolnaSuma = 0;

            // Posledny prvok sa uz nepocita, ten sluzi v sprave prave na kontrolnu sumu
            for (int i = 0; i < paket.Length - 1; i++)
            {
                kontrolnaSuma ^= paket[i];
            }

            return kontrolnaSuma;
        }

        private void PosliSpravu3x(byte[] sprava)
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
                        _commPort.Write(sprava, 0, sprava.Length);

                        if (i < MaxAttempts - 1)
                            Thread.Sleep(WaitingTime);
                    }
                }
            }
            catch
            {
            }
        }

        private SirenType getDruhSireny(int index)
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

        private void SpustiSirenu(SirenType parType)
        {
            if (parType == SirenType.NONE) return;

            byte[] poleBytov = null;
            
                if (parType == SirenType.LONG)
                {
                    poleBytov = new byte[5];
                    poleBytov[0] = STX;
                    poleBytov[1] = (byte)'S';
                    poleBytov[2] = (byte)'2';
                    poleBytov[3] = ETX;
                }
                else if (parType == SirenType.NORMAL)
                {
                    poleBytov = new byte[5];
                    poleBytov[0] = STX;
                    poleBytov[1] = (byte)'S';
                    poleBytov[2] = (byte)'1';
                    poleBytov[3] = ETX;
                }
                else if (parType == SirenType.SHORT)
                {
                    poleBytov = new byte[5];
                    poleBytov[0] = STX;
                    poleBytov[1] = (byte)'S';
                    poleBytov[2] = (byte)'3';
                    poleBytov[3] = ETX;
                }
                else if (parType == SirenType.DISRUPTED)
                {
                    poleBytov = new byte[5];
                    poleBytov[0] = STX;
                    poleBytov[1] = (byte)'S';
                    poleBytov[2] = (byte)'5';
                    poleBytov[3] = ETX;
                }
                
            poleBytov[poleBytov.Length - 1] = getCheckSum(poleBytov);
            PosliSpravu3x(poleBytov);
        }
}