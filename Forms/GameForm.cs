﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Scoreboard.Forms
{
    public partial class GameForm : Form
    {
        public const int MAX_PENALTIES = 4;
        public const int TWO_TEAMS = 2;
        public const int TIMEOUT_MIN_DEFAULT = 1;
        public const int TIMEOUT_SEC_DEFAULT = 0;

        private ScoreboardForm _formScoreBoard;
        private int _team1Goals = 0;
        private int _team2Goals =0;
        private int _period = 1;
        private string _team1Name;
        private string _team2Name;
        private int _secondsT = 0;
        private int _minutesT = 0;
        private int[][] _penalty;
        private Timer _timer = null;
        private bool _timerRunning = false;
        private bool _penaltyRunning = false;
        private Timer _timerPenalty = null;
        private bool _periodEnd = false;
        private Timer _timeoutTimer = null;
        private int[][] _timeouts;


        public GameForm(ScoreboardForm parFormScoreBoard)
        {
            InitializeComponent();
            _formScoreBoard = parFormScoreBoard;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            _formScoreBoard.SetTime(_minutesT, _secondsT);
            UpdateTime(_minutesT,_secondsT);
            _penalty = new int[MAX_PENALTIES][];
            for (int i = 0; i < MAX_PENALTIES; i++)
            {
                _penalty[i] = new int[3];
                _penalty[i][1] = 2;
            }

            for (int i = 0; i < _penalty.Length; i++)
            {
                UpdatePenaltyGf(i+1,_penalty[i][0],_penalty[i][1],_penalty[i][2]);
            }

            _timeouts = new int[TWO_TEAMS][];
            for (int i = 0; i < _timeouts.Length; i++)
            {
                _timeouts[i] = new int[2];
            }

            SetTimeoutLength(TIMEOUT_MIN_DEFAULT,TIMEOUT_SEC_DEFAULT);
        }

        public void SetTimeoutLength(int minutes, int seconds)
        {
            for (int i = 0; i < _timeouts.Length; i++)
            {
                _timeouts[i][0] = minutes;
                _timeouts[i][1] = seconds;
                _formScoreBoard.SetTimeout(i,minutes,seconds);
                UpdateTimeoutGf(i,minutes,seconds);
            }
        }

        private void UpdateTimeoutGf(int team, int minutes, int seconds)
        {
            if (team == 1)
            {
                timeoutT1M.Text = _timeouts[team - 1][0].ToString();
                timeoutT1S.Text = _timeouts[team - 1][1].ToString();
            }
            else if (team == 2)
            {
                timeoutT2M.Text = _timeouts[team - 1][0].ToString();
                timeoutT2S.Text = _timeouts[team - 1][1].ToString();
            }
        }

        private void minusGoal1_Click(object sender, EventArgs e)
        {
            if (_team1Goals > 0)
            {
                _team1Goals --;
                _formScoreBoard.SetGoal(_team1Goals.ToString(), true);
                goalsTeam1.Text = _team1Goals.ToString();
            }
        }

        private void plusGoal1_Click(object sender, EventArgs e)
        {
            _team1Goals ++;
            _formScoreBoard.SetGoal(_team1Goals.ToString(), true);
            goalsTeam1.Text = _team1Goals.ToString();
        }

        private void minusGoal2_Click(object sender, EventArgs e)
        {
            if (_team2Goals > 0)
            {
                _team2Goals --;
                _formScoreBoard.SetGoal(_team2Goals.ToString(), false);
                goalsTeam2.Text = _team2Goals.ToString();
            }
        }

        private void plusGoal2_Click(object sender, EventArgs e)
        {
            _team2Goals ++;
            _formScoreBoard.SetGoal(_team2Goals.ToString(), false);
            goalsTeam2.Text = _team2Goals.ToString();
        }

        private void p1T1ShowPenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.SetPenalty(1,(int)p1T1Number.Value,(int)p1T1Minutes.Value,(int)p1T1Seconds.Value);
            _formScoreBoard.ShowPenalty(1);
        }

        private void p2T1ShowPenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.SetPenalty(2,(int)p2T1Number.Value,(int)p2T1Minutes.Value,(int)p2T1Seconds.Value);
            _formScoreBoard.ShowPenalty(2);
        }

        private void p1T1HidePenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.HidePenalty(1);
        }

        private void p2T1HidePenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.HidePenalty(2);
        }

        private void p1T2ShowPenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.SetPenalty(3,(int)p1T2Number.Value,(int)p1T2Minutes.Value,(int)p1T2Seconds.Value);
            _formScoreBoard.ShowPenalty(3);
        }

        private void p2T2ShowPenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.SetPenalty(4,(int)p2T2Number.Value,(int)p2T2Minutes.Value,(int)p2T2Seconds.Value);
            _formScoreBoard.ShowPenalty(4);
        }

        private void p1T2HidePenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.HidePenalty(3);
        }

        private void p2T2HidePenalty_Click(object sender, EventArgs e)
        {
            _formScoreBoard.HidePenalty(4);
        }

        private void periodMinus_Click(object sender, EventArgs e)
        {
            if (_period > 0)
            {
                _period--;
                period.Text = _period.ToString();
                _formScoreBoard.SetPeriod(_period.ToString());
            }
        }

        private void periodPlus_Click(object sender, EventArgs e)
        {
            if (_period < 4)
            {
                _period++;
                period.Text = _period.ToString();
                _formScoreBoard.SetPeriod(_period.ToString());
            }
        }

        private void setTeam1Name_Click(object sender, EventArgs e)
        {
            if (team1NameBox.Text.Length > 0)
            {
                _team1Name = team1NameBox.Text;
            }
            else
            {
                _team1Name = "Team 1";
            }
            _formScoreBoard.SetTeamName(true,_team1Name);
        }

        private void UploadLogo(bool team1)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
            if (open.ShowDialog() == DialogResult.OK) {
                logo1.Image = new Bitmap(open.FileName);
                logo1Path.Text = open.FileName;

                if (team1)
                    _formScoreBoard.SetLogo(true, logo1.Image);
                else
                    _formScoreBoard.SetLogo(false, logo2.Image);
            }
        }

        private void uploadLogoT1_Click(object sender, EventArgs e)
        {
            UploadLogo(true);
        }

        private void hideT1Logo_Click(object sender, EventArgs e)
        {
            _formScoreBoard.HideLogo(true);
        }

        private void showT1Logo_Click(object sender, EventArgs e)
        {
            _formScoreBoard.ShowLogo(true);
        }

        private void setTeam2Name_Click_1(object sender, EventArgs e)
        {
            if (team2NameBox.Text.Length > 0)
                _team2Name = team2NameBox.Text;
            else
                _team2Name = "Team 2";
            _formScoreBoard.SetTeamName(false,_team2Name);
        }

        private void uploadLogoT2_Click(object sender, EventArgs e)
        {
           UploadLogo(false);
        }

        private void hideT2Logo_Click(object sender, EventArgs e)
        {
            _formScoreBoard.HideLogo(false);
        }

        private void showT2Logo_Click(object sender, EventArgs e)
        {
            _formScoreBoard.ShowLogo(false);
        }


        private void startTime_Click(object sender, EventArgs e)
        {
            if (!_timerRunning && !_periodEnd)
            {
                _timer = new Timer();
                _timer.Tick += DisplayTimeTimer;
                _timer.Enabled = true;
                _timer.Interval = 1000;
                _timer.Start();
                _timerRunning = true;
                StartPenalty();
            }
        }

        private void DisplayTimeTimer(Object myObject, EventArgs myEventArgs)
        {
            if (_secondsT == 0)
            {
                if (_minutesT > 0)
                {
                    _minutesT--;
                    _secondsT = 60;
                    _secondsT--;
                }
            }
            else
            {
                _secondsT--;
            }

            _formScoreBoard.SetTime(_minutesT, _secondsT);
            UpdateTime(_minutesT, _secondsT);

            if (_minutesT == 0 && _secondsT == 0)
            {
                _timerRunning = false;
                _periodEnd = true;
            }
        }

        private void stopTime_Click(object sender, EventArgs e)
        {
            if (_timerRunning && !_periodEnd)
            {
                _timer.Stop();
                _timerRunning = false;
                StopPenalty();
            }
        }

        private void resetTime_Click(object sender, EventArgs e)
        {
            if (_timerRunning) _timer.Stop();
            _minutesT = 15;
            _secondsT = 0;
            _formScoreBoard.SetTime(_minutesT,_secondsT);
            UpdateTime(_minutesT,_secondsT);
            _timerRunning = false;
            _periodEnd = false;
        }

        private void UpdateTime(int minutes, int seconds)
        {
            if (minutes < 10)
                minutesTime.Text = "0" + minutes;
            else
                minutesTime.Text = minutes.ToString();

            if (seconds < 10)
                secondsTime.Text = "0" + seconds;
            else
                secondsTime.Text = seconds.ToString();
        }

        private void p1T1Minutes_ValueChanged(object sender, EventArgs e)
        {
            _penalty[0][1] = (int) p1T1Minutes.Value;
        }

        private void p1T1Seconds_ValueChanged(object sender, EventArgs e)
        {
            _penalty[0][2] = (int) p1T1Seconds.Value;
        }

        private void UpdatePenaltyGf(int position, int number, int minutes, int seconds)
        {
            string sMinutes;
            string sSeconds;
            if (minutes < 10)
                sMinutes = "0" + minutes;
            else
                sMinutes = minutes.ToString();

            if (seconds < 10)
                sSeconds = "0" + seconds;
            else
                sSeconds = seconds.ToString();

            switch (position)
            {
              case 1:
                  p1T1Number.Text = _penalty[0][0].ToString();
                  p1T1Seconds.Text = sSeconds;
                  p1T1Minutes.Text = sMinutes;
                  break;
              case 2:
                  p2T1Number.Text = _penalty[1][0].ToString();
                  p2T1Seconds.Text = sSeconds;
                  p2T1Minutes.Text = sMinutes;
                  break;
              case 3:
                  p1T2Number.Text = _penalty[2][0].ToString();
                  p1T2Seconds.Text = sSeconds;
                  p1T2Minutes.Text = sMinutes;
                  break;
              case 4:
                  p2T2Number.Text = _penalty[3][0].ToString();
                  p2T2Seconds.Text = sSeconds;
                  p2T2Minutes.Text = sMinutes;
                  break;
              default:
                  throw new ArgumentException("Index is out of range");
            }
        }

        private void ResetPenalty(int position)
        {
            for (int i = 0; i < 3; i++)
            {
                _penalty[position-1][i] = 0;
            }
            _formScoreBoard.SetPenalty(position,_penalty[position-1][0],_penalty[position-1][1],_penalty[position-1][2]);
            UpdatePenaltyGf(position,_penalty[position-1][0],_penalty[position-1][1], _penalty[position-1][2]);
        }

        private void resetT1P1_Click(object sender, EventArgs e)
        {
            ResetPenalty(1);
        }

        private void resetT1P2_Click(object sender, EventArgs e)
        {
            ResetPenalty(2);
        }

        private void resetT2P1_Click(object sender, EventArgs e)
        {
            ResetPenalty(3);
        }

        private void resetT2P2_Click(object sender, EventArgs e)
        {
            ResetPenalty(4);
        }

        private void StartPenalty()
        {
            if (!_penaltyRunning && !_periodEnd && _timerRunning)
            {
                _timerPenalty = new Timer();
                _timerPenalty.Tick += new EventHandler(DisplayTimePenalty);
                _timerPenalty.Enabled = true;
                _timerPenalty.Interval = 1000;
                _timerPenalty.Start();
                _penaltyRunning = true;
            }
        }

        private void DisplayTimePenalty(Object myObject, EventArgs myEventArgs)
        {
            for (int i = 0; i < _penalty.Length; i++)
            {
                if (_penalty[i][1] > 0 || _penalty[i][2] > 0)
                {
                    if (_penalty[i][2] == 0)
                    {
                        if (_penalty[i][1] > 0)
                        {
                            _penalty[i][1]--;
                            _penalty[i][2] = 60;
                            _penalty[i][2]--;
                        }
                    }
                    else
                    {
                        _penalty[i][2]--;
                    }

                    UpdatePenaltyGf(i + 1, _penalty[i][0], _penalty[i][1], _penalty[i][2]);
                    _formScoreBoard.SetPenalty(i + 1, _penalty[i][0], _penalty[i][1], _penalty[i][2]);
                }
                else
                {
                    _formScoreBoard.HidePenalty(i + 1);
                }
            }
        }

        private void StopPenalty()
        {
            if (_penaltyRunning && !_timerRunning)
            {
                _timerPenalty.Stop();
                _penaltyRunning = false;
            }
        }

        private void p1T1Number_ValueChanged(object sender, EventArgs e)
        {
            _penalty[0][0] = (int) p1T1Number.Value;
        }

        private void p2T1Number_ValueChanged(object sender, EventArgs e)
        {
            _penalty[1][0] = (int) p2T1Number.Value;
        }

        private void p1T2Number_ValueChanged(object sender, EventArgs e)
        {
            _penalty[2][0] = (int) p1T2Number.Value;
        }

        private void p2T2Number_ValueChanged(object sender, EventArgs e)
        {
            _penalty[3][0] = (int) p2T2Number.Value;
        }

        private void p2T1Seconds_ValueChanged(object sender, EventArgs e)
        {
            _penalty[1][2] = (int) p2T1Seconds.Value;
        }

        private void p2T1Minutes_ValueChanged(object sender, EventArgs e)
        {
            _penalty[1][1] = (int)  p2T1Minutes.Value;
        }

        private void p1T2Minutes_ValueChanged(object sender, EventArgs e)
        {
            _penalty[2][1] = (int) p1T2Minutes.Value;
        }

        private void p1T2Seconds_ValueChanged(object sender, EventArgs e)
        {
            _penalty[2][2] = (int) p1T2Seconds.Value;
        }

        private void p2T2Minutes_ValueChanged(object sender, EventArgs e)
        {
            _penalty[3][1] = (int) p2T2Minutes.Value;
        }

        private void p2T2Seconds_ValueChanged(object sender, EventArgs e)
        {
            _penalty[3][2] = (int) p2T2Seconds.Value;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            _formScoreBoard = ScoreboardForm.GetInstance();
            var area = Screen.AllScreens[1].Bounds;
            _formScoreBoard.SetSize(area.Width,area.Height);
            var location = area.Location;
            location.Offset((area.Width - _formScoreBoard.Width) / 2, (area.Height - _formScoreBoard.Height) / 2);
            _formScoreBoard.Location = location;

            if (!_formScoreBoard.IsActive)
            {
                _formScoreBoard.Show();
                _formScoreBoard.IsActive = true;
            }
            else if (!_formScoreBoard.IsDisposed)
            {
                _formScoreBoard.BringToFront();
            }

            for (var i = 1; i <= MAX_PENALTIES; i++) _formScoreBoard.HidePenalty(i);
        }

        private void closeScoreboardBtn_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard != null)
            {
                _formScoreBoard.Dispose();
                _formScoreBoard.ResetInstance();
                _formScoreBoard.IsActive = false;
            }
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = new ControlForm(_formScoreBoard);
            control.ShowDialog();
        }
    }
}