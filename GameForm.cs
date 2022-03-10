using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Scoreboard
{
    public partial class GameForm : Form
    {
        private ScoreboardForm formScoreBoard;
        private int _team1Goals = 0;
        private int _team2Goals =0;
        private int _period = 1;
        private string _team1Name;
        private string _team2Name;
        private int _secondsT = 0;
        private int _minutesT = 0;
        private int[][] penalty;
        private Timer _timer = null;
        private bool _timerRunning = false;
        private bool _penaltyRunning = false;
        private Timer _timerPenalty = null;
        private bool _periodEnd = false;
        private int penaltyCount = 4;


        public GameForm(ScoreboardForm parFormScoreBoard)
        {
            InitializeComponent();
            formScoreBoard = parFormScoreBoard;
        }

        private void minusGoal1_Click(object sender, EventArgs e)
        {
            if (_team1Goals > 0)
            {
                _team1Goals --;
                formScoreBoard.SetGoal(_team1Goals.ToString(), true);
                goalsTeam1.Text = _team1Goals.ToString();
            }
        }

        private void plusGoal1_Click(object sender, EventArgs e)
        {
            _team1Goals ++;
            formScoreBoard.SetGoal(_team1Goals.ToString(), true);
            goalsTeam1.Text = _team1Goals.ToString();
        }

        private void goalsTeam1_Click(object sender, EventArgs e)
        {
        }

        private void minusGoal2_Click(object sender, EventArgs e)
        {
            if (_team2Goals > 0)
            {
                _team2Goals --;
                formScoreBoard.SetGoal(_team2Goals.ToString(), false);
                goalsTeam2.Text = _team2Goals.ToString();
            }
        }

        private void plusGoal2_Click(object sender, EventArgs e)
        {
            _team2Goals ++;
            formScoreBoard.SetGoal(_team2Goals.ToString(), false);
            goalsTeam2.Text = _team2Goals.ToString();
        }

        private void p1T1ShowPenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.SetPenalty(1,(int)p1T1Number.Value,(int)p1T1Minutes.Value,(int)p1T1Seconds.Value);
            formScoreBoard.ShowPenalty(1);
        }

        private void p2T1ShowPenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.SetPenalty(2,(int)p2T1Number.Value,(int)p2T1Minutes.Value,(int)p2T1Seconds.Value);
            formScoreBoard.ShowPenalty(2);
        }

        private void p1T1HidePenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.HidePenalty(1);
        }

        private void p2T1HidePenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.HidePenalty(2);
        }

        private void p1T2ShowPenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.SetPenalty(3,(int)p1T2Number.Value,(int)p1T2Minutes.Value,(int)p1T2Seconds.Value);
            formScoreBoard.ShowPenalty(3);
        }

        private void p2T2ShowPenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.SetPenalty(4,(int)p2T2Number.Value,(int)p2T2Minutes.Value,(int)p2T2Seconds.Value);
            formScoreBoard.ShowPenalty(4);
        }

        private void p1T2HidePenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.HidePenalty(3);
        }

        private void p2T2HidePenalty_Click(object sender, EventArgs e)
        {
            formScoreBoard.HidePenalty(4);
        }

        private void periodMinus_Click(object sender, EventArgs e)
        {
            if (_period > 0)
            {
                _period--;
                period.Text = _period.ToString();
                formScoreBoard.SetPeriod(_period.ToString());
            }
        }

        private void periodPlus_Click(object sender, EventArgs e)
        {
            if (_period < 6)
            {
                _period++;
                period.Text = _period.ToString();
                formScoreBoard.SetPeriod(_period.ToString());
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
            formScoreBoard.SetTeamName(true,_team1Name);
        }


        private void uploadLogoT1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();  
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
            if (open.ShowDialog() == DialogResult.OK) {  
                // display image in picture box  
                logo1.Image = new Bitmap(open.FileName);  
                // image file path  
                logo1Path.Text = open.FileName;
                formScoreBoard.SetLogo(true,logo1.Image);
            }
        }

        private void hideT1Logo_Click(object sender, EventArgs e)
        {
            formScoreBoard.HideLogo(true);
        }

        private void showT1Logo_Click(object sender, EventArgs e)
        {
            formScoreBoard.ShowLogo(true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void team2NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setTeam2Name_Click_1(object sender, EventArgs e)
        {
            if (team2NameBox.Text.Length > 0)
            {
                _team2Name = team2NameBox.Text;
            }
            else
            {
                _team2Name = "Team 2";
            }
            formScoreBoard.SetTeamName(false,_team2Name);
        }

        private void uploadLogoT2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();  
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
            if (open.ShowDialog() == DialogResult.OK) {  
                // display image in picture box  
                logo2.Image = new Bitmap(open.FileName);  
                // image file path  
                logo2Path.Text = open.FileName;
                formScoreBoard.SetLogo(false,logo2.Image);
            }
        }

        private void hideT2Logo_Click(object sender, EventArgs e)
        {
            formScoreBoard.HideLogo(false);
        }

        private void showT2Logo_Click(object sender, EventArgs e)
        {
            formScoreBoard.ShowLogo(false);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            formScoreBoard.SetTime(_minutesT, _secondsT);
            UpdateTime(_minutesT,_secondsT);
            penalty = new int[penaltyCount][];
            for (int i = 0; i < penaltyCount; i++)
            {
                penalty[i] = new int[3];
                penalty[i][1] = 2;
            }

            for (int i = 0; i < penalty.Length; i++)
            {
                UpdatePenaltyGF(i+1,penalty[i][0],penalty[i][1],penalty[i][2]);
            }
        }

        private void startTime_Click(object sender, EventArgs e)
        {
            if (!_timerRunning && !_periodEnd)
            {
                _timer = new Timer();
                _timer.Tick += new EventHandler(DisplayTimeTimer);
                _timer.Enabled = true;
                _timer.Interval = 1000; // 1000 ms is one second
                _timer.Start();
                _timerRunning = true;
                StartPenalty();
            }
        }

        public void DisplayTimeTimer(Object myObject, EventArgs myEventArgs)
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
            formScoreBoard.SetTime(_minutesT,_secondsT);
            UpdateTime(_minutesT,_secondsT);

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
            if (_timerRunning)
            {
                _timer.Stop();
            }
            _minutesT = 15;
            _secondsT = 0;
            formScoreBoard.SetTime(_minutesT,_secondsT);
            UpdateTime(_minutesT,_secondsT);
            _timerRunning = false;
            _periodEnd = false;
        }

        private void UpdateTime(int minutes, int seconds)
        {
            if (minutes < 10)
            {
                minutesTime.Text = "0" + minutes.ToString();
            }
            else
            {
                minutesTime.Text = minutes.ToString();
            }

            if (seconds < 10)
            {
                secondsTime.Text = "0" + seconds.ToString();
            }
            else
            {
                secondsTime.Text = seconds.ToString();
            }
        }

        private void p1T1Minutes_ValueChanged(object sender, EventArgs e)
        {
            penalty[0][1] = (int) p1T1Minutes.Value;
        }

        private void p1T1Seconds_ValueChanged(object sender, EventArgs e)
        {
            penalty[0][2] = (int) p1T1Seconds.Value;
        }

        public void UpdatePenaltyGF(int position, int number, int minutes, int seconds)
        {
            string sMinutes;
            string sSeconds;
            if (minutes < 10)
            {
                sMinutes = "0" + minutes;
            }
            else
            {
                sMinutes = minutes.ToString();
            }

            if (seconds < 10)
            {
                sSeconds = "0" + seconds;
            }
            else
            {
                sSeconds = seconds.ToString();
            }

            switch (position)
            {
              case 1:
                  p1T1Number.Text = penalty[0][0].ToString();
                  p1T1Seconds.Text = sSeconds;
                  p1T1Minutes.Text = sMinutes;
                  break;
              case 2:
                  p2T1Number.Text = penalty[1][0].ToString();
                  p2T1Seconds.Text = sSeconds;
                  p2T1Minutes.Text = sMinutes;
                  break;
              case 3:
                  p1T2Number.Text = penalty[2][0].ToString();
                  p1T2Seconds.Text = sSeconds;
                  p1T2Minutes.Text = sMinutes;
                  break;
              case 4:
                  p2T2Number.Text = penalty[3][0].ToString();
                  p2T2Seconds.Text = sSeconds;
                  p2T2Minutes.Text = sMinutes;
                  break;
              default:
                  throw new ArgumentException("Index is out of range");
            }
        }

        private void resetT1P1_Click(object sender, EventArgs e)
        {
            penalty[0][0] = 0;
            penalty[0][1] = 0;
            penalty[0][2] = 0;
            formScoreBoard.SetPenalty(1,penalty[0][0],penalty[0][1],penalty[0][2]);
            UpdatePenaltyGF(1,penalty[0][0],penalty[0][1], penalty[0][2] );

        }

        private void resetT1P2_Click(object sender, EventArgs e)
        {
            penalty[1][0] = 0;
            penalty[1][1] = 0;
            penalty[1][2] = 0;
            formScoreBoard.SetPenalty(2,penalty[1][0],penalty[1][1],penalty[1][2]);
            UpdatePenaltyGF(2,penalty[1][0],penalty[1][1],penalty[1][2]);
        }

        private void resetT2P1_Click(object sender, EventArgs e)
        {
            penalty[2][0] = 0;
            penalty[2][1] = 0;
            penalty[2][2] = 0;
            formScoreBoard.SetPenalty(3,penalty[2][0],penalty[2][1],penalty[2][2]);
            UpdatePenaltyGF(3,penalty[2][0],penalty[2][1],penalty[2][2]);
        }

        private void resetT2P2_Click(object sender, EventArgs e)
        {
            penalty[3][0] = 0;
            penalty[3][1] = 0;
            penalty[3][2] = 0;
            formScoreBoard.SetPenalty(4,penalty[3][0],penalty[3][1],penalty[3][2]);
            UpdatePenaltyGF(4,penalty[3][0],penalty[3][1],penalty[3][2]);
        }

        private void penaltyStart_Click(object sender, EventArgs e)
        {
            StartPenalty();
        }

        public void StartPenalty()
        {
            if (!_penaltyRunning && !_periodEnd && _timerRunning)
            {
                _timerPenalty = new Timer();
                _timerPenalty.Tick += new EventHandler(DisplayTimePenalty);
                _timerPenalty.Enabled = true;
                _timerPenalty.Interval = 1000; // 1000 ms is one second
                _timerPenalty.Start();
                _penaltyRunning = true;
            }
        }

        public void DisplayTimePenalty(Object myObject, EventArgs myEventArgs)
        {
            for (int i = 0; i < penalty.Length; i++)
            {
                if (penalty[i][1] > 0 || penalty[i][2] > 0)
                {
                    if (penalty[i][2] == 0)
                    {
                        if (penalty[i][1] > 0)
                        {
                            penalty[i][1]--;
                            penalty[i][2] = 60;
                            penalty[i][2]--;
                        }
                    }
                    else
                    {
                        penalty[i][2]--;
                    }
                    UpdatePenaltyGF(i+1,penalty[i][0],penalty[i][1],penalty[i][2]);
                    formScoreBoard.SetPenalty(i+1,penalty[i][0],penalty[i][1],penalty[i][2]);
                }
                else
                {
                    formScoreBoard.HidePenalty(i+1);
                }
            }
        }

        private void penaltyStop_Click(object sender, EventArgs e)
        {
            StopPenalty();
        }

        public void StopPenalty()
        {
            if (_penaltyRunning && !_timerRunning)
            {
                _timerPenalty.Stop();
                _penaltyRunning = false;
            }
        }

        private void p1T1Number_ValueChanged(object sender, EventArgs e)
        {
            penalty[0][0] = (int) p1T1Number.Value;
        }

        private void p2T1Number_ValueChanged(object sender, EventArgs e)
        {
            penalty[1][0] = (int) p2T1Number.Value;
        }

        private void p1T2Number_ValueChanged(object sender, EventArgs e)
        {
            penalty[2][0] = (int) p1T2Number.Value;
        }

        private void p2T2Number_ValueChanged(object sender, EventArgs e)
        {
            penalty[3][0] = (int) p2T2Number.Value;
        }

        private void p2T1Seconds_ValueChanged(object sender, EventArgs e)
        {
            penalty[1][2] = (int) p2T1Seconds.Value;
        }

        private void p2T1Minutes_ValueChanged(object sender, EventArgs e)
        {
            penalty[1][1] = (int)  p2T1Minutes.Value;
        }

        private void p1T2Minutes_ValueChanged(object sender, EventArgs e)
        {
            penalty[2][1] = (int) p1T2Minutes.Value;
        }

        private void p1T2Seconds_ValueChanged(object sender, EventArgs e)
        {
            penalty[2][2] = (int) p1T2Seconds.Value;
        }

        private void p2T2Minutes_ValueChanged(object sender, EventArgs e)
        {
            penalty[3][1] = (int) p2T2Minutes.Value;
        }

        private void p2T2Seconds_ValueChanged(object sender, EventArgs e)
        {
            penalty[3][2] = (int) p2T2Seconds.Value;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            formScoreBoard = ScoreboardForm.GetInstance();
            var area = Screen.AllScreens[1].Bounds;
            formScoreBoard.SetSize(area.Width,area.Height);
            var location = area.Location;
            location.Offset((area.Width - formScoreBoard.Width) / 2, (area.Height - formScoreBoard.Height) / 2);
            formScoreBoard.Location = location;

            if (!formScoreBoard.IsActive)
            {
                formScoreBoard.Show();
                formScoreBoard.IsActive = true;
            }
            else if (!formScoreBoard.IsDisposed)
            {
                formScoreBoard.BringToFront();
            }

            for (int i = 1; i <= penaltyCount; i++)
            {
                formScoreBoard.HidePenalty(i);
            }
        }

        private void closeScoreboardBtn_Click(object sender, EventArgs e)
        {
            if (formScoreBoard != null)
            {
                formScoreBoard.Dispose();
                formScoreBoard.ResetInstance();
                formScoreBoard.IsActive = false;
            }
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = new ControlForm(formScoreBoard);
            control.ShowDialog();
            
        }
    }
}
