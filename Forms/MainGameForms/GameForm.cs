using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes;
using Scoreboard.Classes.Database;
using Scoreboard.Classes.GameStatistics;
using Scoreboard.Forms.Appearance;
using Scoreboard.Forms.AppSettings;
using Scoreboard.Forms.DBForms;
using Scoreboard.Forms.Statistics;
using Timer = System.Windows.Forms.Timer;

namespace Scoreboard.Forms.MainGameForms
{
    public partial class GameForm : Form
    {
        private const int MaxPenalties = 4;
        private const int TwoTeams = 2;


        private ScoreboardForm _formScoreBoard;
        private Database _databaseGame;
        private VideoPlayerForm _videoPlayerForm;
        private SetTimes _gameTimes;
        private MatchStatistics _matchStats;
        private ControlForm _controlForm;
        private StatisticsSettings _statSettings;
        private ExportStatsForm _exportSettings;

        private Team _team1;
        private Team _team2;
        //private int _team1Goals = 0;
        //private int _team2Goals =0;
        //private string _team1Name = "Team1";
        //private string _team2Name = "Team2";

        //private int _secondsT = 0;
        //private int _minutesT = 0;
        private Time _matchTime;
        private Time _elapsedTime;
        private int _period = 1;

        private bool _breakRunning = false;
        private bool _periodEnd = false;
        private bool _periodStarted = false;
        private bool _timeout1Running = false;
        private bool _timeout2Running = false;
        private bool[] _activePenalty;

        private int[][] _penalty;
        private Time[] _timeouts;

        private Timer _timer = null;
        private Timer _timerPenalty = null;
        private Timer _timeoutTimer = null;
        
        
        

        

        public Database DatabaseGame
        {
            get => _databaseGame;
            set => _databaseGame = value;
        }


        public GameForm(ScoreboardForm parFormScoreBoard)
        {
            _videoPlayerForm = new VideoPlayerForm();
            _databaseGame = new Database();
            _gameTimes = new SetTimes(this);
            _matchStats = new MatchStatistics("Team1", "Team2");
            _statSettings = new StatisticsSettings();
            _exportSettings = new ExportStatsForm();

            InitializeComponent();
            _formScoreBoard = parFormScoreBoard;
            SetTime(_gameTimes.PeriodLength);
            _timer = ResetTimer();
            _timerPenalty = ResetTimer();
            _timeoutTimer = ResetTimer();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            _formScoreBoard.SetTime(_matchTime);
            UpdateTime(_matchTime);
            _penalty = new int[MaxPenalties][];
            _activePenalty = new bool[MaxPenalties];
            for (int i = 0; i < MaxPenalties; i++)
            {
                _penalty[i] = new int[3];
                _activePenalty[i] = false;
            }

            _timeouts = new Time[TwoTeams];
            for (int i = 0; i < _timeouts.Length; i++)
            {
                SetTimeoutLength(i + 1, _gameTimes.TimeoutLength);
            }

            InitBoards();
        }

        private Timer ResetTimer()
        {
            var parTimer = new Timer();
            parTimer.Interval = 1000;
            return parTimer;
        }

        public void InitBoards()
        {
            period.Text = _period.ToString();
            _formScoreBoard.SetPeriod(_period.ToString());
            minutesTime.Text = _matchTime.Minutes.ToString();
            secondsTime.Text = _matchTime.Seconds.ToString();
            _formScoreBoard.SetTime(_matchTime);
            goalsTeam1.Text = _matchStats.TeamStats[0].Goals.ToString();
            _formScoreBoard.SetGoal(true,_matchStats.TeamStats[0].Goals);
            goalsTeam2.Text = _matchStats.TeamStats[1].Goals.ToString();
            _formScoreBoard.SetGoal(false,_matchStats.TeamStats[1].Goals);
            for (int i = 0; i < _penalty.Length; i++)
            {
                UpdatePenaltyGf(i+1,_penalty[i][0],_penalty[i][1],_penalty[i][2]);
                _formScoreBoard.SetPenalty(i+1,_penalty[i][0],_penalty[i][1],_penalty[i][2]);
            }
            for (int i = 0; i < _timeouts.Length; i++)
            {
                UpdateTimeoutGf(i+1,_timeouts[i]);
                _formScoreBoard.SetTimeout(i+1,_timeouts[i]);
            }
        }

        public void SetTimeoutLength(int team, Time parTime)
        {
            _timeouts[team - 1] = parTime;
            _formScoreBoard.SetTimeout(team,parTime);
            UpdateTimeoutGf(team,parTime);

        }

        public void SetTime(Time parTime)
        {
            _matchTime = parTime;
        }

        private void UpdateTimeoutGf(int team, Time parTime)
        {
            if (team == 1)
            {
                timeoutT1M.Text = _timeouts[team - 1].Minutes.ToString();
                timeoutT1S.Text = _timeouts[team - 1].Seconds.ToString();
            }
            else if (team == 2)
            {
                timeoutT2M.Text = _timeouts[team - 1].Minutes.ToString();
                timeoutT2S.Text = _timeouts[team - 1].Seconds.ToString();
            }
        }

        private void minusGoal1_Click(object sender, EventArgs e)
        {
            if (_matchStats.TeamStats[0].Goals > 0)
            {
                _matchStats.TeamStats[0].Goals --;
                _formScoreBoard.SetGoal(true,_matchStats.TeamStats[0].Goals);
                goalsTeam1.Text = _matchStats.TeamStats[0].Goals.ToString();
            }
        }

        private void GoalSelectPlayer(int team)
        {
            var t1 = _matchTime;
            var t2 = _gameTimes.PeriodLength;
            t2.SubtractTime(t1);
            if (team == 1)
            {
                if (_team1 == null || _team1.Players.Count < 1) return;
                SelectPlayerGoal varGoal = new SelectPlayerGoal(1, _matchStats, _team1.Players,t2);
                varGoal.Show();
            }
            if (team == 2)
            {
                if (_team2 == null || _team2.Players.Count < 1) return;
                SelectPlayerGoal varGoal = new SelectPlayerGoal(2, _matchStats, _team2.Players,t2);
                varGoal.Show();
            }
        }

        private void plusGoal1_Click(object sender, EventArgs e)
        {
            StopTime();
            _matchStats.TeamStats[0].Goals ++;
            _formScoreBoard.SetGoal(true,_matchStats.TeamStats[0].Goals);
            goalsTeam1.Text = _matchStats.TeamStats[0].Goals.ToString();
            GoalSelectPlayer(1);
        }

        private void minusGoal2_Click(object sender, EventArgs e)
        {
            if (_matchStats.TeamStats[1].Goals > 0)
            {
                _matchStats.TeamStats[1].Goals --;
                _formScoreBoard.SetGoal(false,_matchStats.TeamStats[1].Goals);
                goalsTeam2.Text = _matchStats.TeamStats[1].Goals.ToString();
            }
        }

        private void plusGoal2_Click(object sender, EventArgs e)
        {
            StopTime();
            _matchStats.TeamStats[1].Goals ++;
            _formScoreBoard.SetGoal(false,_matchStats.TeamStats[1].Goals);
            goalsTeam2.Text = _matchStats.TeamStats[1].Goals.ToString();
            GoalSelectPlayer(2);
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

        private void UpdatePeriod()
        {
            period.Text = _period.ToString();
            _formScoreBoard.SetPeriod(_period.ToString());
            _periodStarted = false;
        }

        private void periodMinus_Click(object sender, EventArgs e)
        {
            if (_period > 1)
            {
                _period--;
                UpdatePeriod();
            }
        }

        private void periodPlus_Click(object sender, EventArgs e)
        {
            if (_period < 3)
            {
                _period++;
                UpdatePeriod();
            }
        }

        private void UpdateTeam1Name()
        {
            if (team1NameBox.Text.Length > 0 && !Equals(team2NameBox.Text,team1NameBox.Text))
            {
                _matchStats.TeamStats[0].Name = team1NameBox.Text;
                team1NameBox.Text = "Team1";
            }
            else
            {
                _matchStats.TeamStats[0].Name = "Team1";
            }
            _formScoreBoard.SetTeamName(true, _matchStats.TeamStats[0].Name);
        }

        private void setTeam1Name_Click(object sender, EventArgs e)
        {
            UpdateTeam1Name();
        }

        private void UploadLogo(bool team1)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";  
            if (open.ShowDialog() == DialogResult.OK) {
                if (team1)
                {
                    logo1.Image = new Bitmap(open.FileName);
                    logo1Path.Text = open.FileName;
                    _formScoreBoard.SetLogo(true, logo1.Image);
                }
                else
                {
                    logo2.Image = new Bitmap(open.FileName);
                    logo2Path.Text = open.FileName;
                    _formScoreBoard.SetLogo(false, logo2.Image);
                }
                
            }
        }

        private void UploadLogo(bool team1, string parPath)
        {
            if (parPath.Length == 0) return;

                if (team1)
                {
                    logo1.Image = new Bitmap(parPath);
                    logo1Path.Text = parPath;
                    _formScoreBoard.SetLogo(true, logo1.Image);
                }
                else
                {
                    logo2.Image = new Bitmap(parPath);
                    logo2Path.Text = parPath;
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

        private void UpdateTeam2Name()
        {
            if (team2NameBox.Text.Length > 0 && !Equals(team2NameBox.Text,team1NameBox.Text))
            {
                _matchStats.TeamStats[1].Name = team2NameBox.Text;
            }
            else
            {
                _matchStats.TeamStats[1].Name = "Team2";
                team2NameBox.Text = "Team2";
            }
            _formScoreBoard.SetTeamName(false,  _matchStats.TeamStats[1].Name);
        }

        private void setTeam2Name_Click_1(object sender, EventArgs e)
        {
            UpdateTeam2Name();
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

        private void StartTimer()
        {
            if (!_timer.Enabled && !_periodEnd && !_matchTime.IsZero() && (!_timeoutTimer.Enabled))
            {
                _timer = ResetTimer();
                _timer.Tick += DisplayTimeTimer;
                _timer.Enabled = true;
                _timer.Start();
                if (!_periodStarted)
                {
                    _matchStats.CreateStartPeriodEvent(_period);
                    _periodStarted = true;
                }
                StartPenalty();
            }
        }

        private void startTime_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void DisplayTimeTimer(Object myObject, EventArgs myEventArgs)
        {
            _matchTime.TickMinus();
            _elapsedTime.TickPlus();
            var t1 = _matchTime;
            var t2 = _gameTimes.PeriodLength;
            t2.SubtractTime(t1);
            if (t2.Minutes == 1 && t2.Seconds == 0)
            {
                _matchStats.CreateLastMinuteEvent(_period);
            }

            _formScoreBoard.SetTime(_matchTime);
            UpdateTime(_matchTime);

            if (_matchTime.IsZero())
            {
                StopTime();
                _timer.Enabled = false;
                if (!_periodEnd)
                {
                    _periodEnd = true;
                    _periodStarted = false;
                    MessageBox.Show(@"Period ended" , @"Timer stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _matchStats.CreateEndPeriodEvent(_period);
                }
                else
                {
                    _breakRunning = false;
                    _periodEnd = false;
                    _period++;
                    SetTime(_gameTimes.PeriodLength);
                    InitBoards();
                    MessageBox.Show(@"Break ended" , @"Timer stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void StopTime()
        {
            if (_timer.Enabled && !_periodEnd)
            {
                _timer.Stop();
                _timer.Enabled = false;
                StopPenalty();
                
            }
        }

        private void stopTime_Click(object sender, EventArgs e)
        {
            StopTime();
        }

        private void resetTime_Click(object sender, EventArgs e)
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
            }
            _matchTime = _gameTimes.PeriodLength;
            _timer.Enabled = false;
            _periodEnd = false;
            _periodStarted = false;
            InitBoards();
        }

        private void UpdateTime(Time parTime)
        {
            if (parTime.Minutes < 10)
                minutesTime.Text = "0" + parTime.Minutes;
            else
                minutesTime.Text = parTime.Minutes.ToString();

            if (parTime.Seconds < 10)
                secondsTime.Text = "0" + parTime.Seconds;
            else
                secondsTime.Text = parTime.Seconds.ToString();
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

                  penP1T1.Text = _penalty[0][0].ToString();
                  penMinP1T1.Text = sMinutes;
                  penSecP1T1.Text = sSeconds;
                  break;
              case 2:
                  p2T1Number.Text = _penalty[1][0].ToString();
                  p2T1Seconds.Text = sSeconds;
                  p2T1Minutes.Text = sMinutes;

                  penP2T1.Text = _penalty[1][0].ToString();
                  penMinP2T1.Text = sMinutes;
                  penSecP2T1.Text = sSeconds;
                  break;
              case 3:
                  p1T2Number.Text = _penalty[2][0].ToString();
                  p1T2Seconds.Text = sSeconds;
                  p1T2Minutes.Text = sMinutes;

                  penP1T2.Text = _penalty[2][0].ToString();
                  penMinP1T2.Text = sMinutes;
                  penSecP1T2.Text = sSeconds;
                  break;
              case 4:
                  p2T2Number.Text = _penalty[3][0].ToString();
                  p2T2Seconds.Text = sSeconds;
                  p2T2Minutes.Text = sMinutes;

                  penP2T2.Text = _penalty[3][0].ToString();
                  penMinP2T2.Text = sMinutes;
                  penSecP2T2.Text = sSeconds;
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
            if (!_timerPenalty.Enabled && !_periodEnd && _timer.Enabled)
            {
                _timerPenalty = ResetTimer();
                _timerPenalty.Tick += new EventHandler(DisplayTimePenalty);
                _timerPenalty.Enabled = true;
                _timerPenalty.Start();

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
                    if (_activePenalty[i])
                    {
                        _matchStats.EndPenaltyEvent(i + 1);
                        _activePenalty[i] = false;
                    }
                    
                }
            }
        }

        private void StopPenalty()
        {
            if (_timerPenalty.Enabled && !_timer.Enabled)
            {
                _timerPenalty.Stop();
                _timerPenalty.Enabled = false;
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

        private void ShowScoreBoard()
        {
            _formScoreBoard = ScoreboardForm.GetInstance();
            if (!_formScoreBoard.IsActive)
            {
                _formScoreBoard.Show();
                _formScoreBoard.IsActive = true;
            }
            else if (!_formScoreBoard.IsDisposed)
            {
                _formScoreBoard.BringToFront();
            }

            for (var i = 1; i <= MaxPenalties; i++) _formScoreBoard.HidePenalty(i);
            InitBoards();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            ShowScoreBoard();
        }

        private void CloseScoreBoard()
        {
            if (_formScoreBoard != null)
            {
                if (_controlForm.BlackActive) _controlForm.BlacForm.Dispose();
                _formScoreBoard.Dispose();
                _formScoreBoard.ResetInstance();
                _formScoreBoard.IsActive = false;
            }
        }

        private void closeScoreboardBtn_Click(object sender, EventArgs e)
        {
            CloseScoreBoard();
        }

        private void startTimeoutT1_Click(object sender, EventArgs e)
        {
            if (!_timeoutTimer.Enabled && !_timeouts[0].IsZero() && !_breakRunning && !_timeout1Running)
            {
                StartTimeout(1);
                _timeoutTimer.Enabled = true;
                _timeout1Running = true;
                _matchStats.CreateTimeoutEvent(1,_elapsedTime);
            }
        }

        private void startTimeoutT2_Click(object sender, EventArgs e)
        {
            if (!_timeoutTimer.Enabled && !_timeouts[1].IsZero() && !_breakRunning && !_timeout2Running)
            {
                StartTimeout(2);
                _timeoutTimer.Enabled = true;
                _timeout2Running = true;
                _matchStats.CreateTimeoutEvent(2,_elapsedTime);
            }
        }

        private void StartTimeout(int team)
        {
            _timeoutTimer = ResetTimer();
            if (team == 1)
            {
                _timeoutTimer.Tick += DisplayTimeTimeout1;
            }
            else if (team == 2)
            {
                _timeoutTimer.Tick += DisplayTimeTimeout2;
            }
            _timeoutTimer.Enabled = true;
            _timeoutTimer.Start();
            StopPenalty();
            StopTime();
            _timer.Enabled = false;
            _timerPenalty.Enabled = false;
        }

        private void CountTimeout(int team)
        {
            _timeouts[team-1].TickMinus();
            _elapsedTime.TickPlus();
            

            _formScoreBoard.SetTimeout(team,_timeouts[team-1]);
            UpdateTimeoutGf(team,_timeouts[team-1]);
            

            if (_timeouts[team-1].IsZero())
            {
                _timeoutTimer.Stop();
                if (team == 1)
                {
                    _timeoutTimer.Enabled = false;
                } 
                else if (team == 2)
                {
                    _timeoutTimer.Enabled = false;
                }
                MessageBox.Show(@"Timeout ended" , @"Timer stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayTimeTimeout1(Object myObject, EventArgs myEventArgs)
        {
            CountTimeout(1);
        }

        private void DisplayTimeTimeout2(Object myObject, EventArgs myEventArgs)
        {
            CountTimeout(2);
        }

        private void cancelTimeoutT1_Click(object sender, EventArgs e)
        {
            if (_timeouts[0].IsZero()) return;
            if (_timeoutTimer.Enabled && _timeout1Running)
            {
                _timeoutTimer.Stop();
                SetTimeoutLength(1,_gameTimes.TimeoutLength);
                _timeoutTimer.Enabled = false;
                _timeout1Running = false;
            }
        }

        private void cancelTimeoutT2_Click(object sender, EventArgs e)
        {
            if(_timeouts[1].IsZero()) return;
            if (_timeoutTimer.Enabled && _timeout2Running)
            {
                _timeoutTimer.Stop();
                SetTimeoutLength(2,_gameTimes.TimeoutLength);
                _timeoutTimer.Enabled = false;
                _timeout2Running = false;
            }
        }

        private void startBreak_Click(object sender, EventArgs e)
        {
            if (_periodEnd && !_breakRunning && !_timer.Enabled && (_period < 3))
            {
                _matchTime = _gameTimes.BreakLength;
                _timer = ResetTimer();
                _timer.Tick += DisplayTimeTimer;
                _timer.Enabled = true;
                _timer.Start();
                _breakRunning = true;
                period.Text = "B";
                _formScoreBoard.SetPeriod("B");
                _formScoreBoard.SetTime(_matchTime);
                UpdateTime(_matchTime);
            }
        }

        private void cancelBreak_Click(object sender, EventArgs e)
        {
            if (_breakRunning && _timer.Enabled)
            {
                _timer.Stop();
                _matchTime = _gameTimes.BreakLength;
                _breakRunning = false;
                _timer.Enabled = false;
                _formScoreBoard.SetTime(_matchTime);
                UpdateTime(_matchTime);
            }
        }

        public void UpdateTeams(Database parDB)
        {
            if (parDB.TeamList != null)
            {
                _databaseGame.TeamList = parDB.TeamList;
            }
        }

        public void UpdateAds(Database parDB)
        {
            if (parDB.AdvList != null)
            {
                _databaseGame.AdvList = parDB.AdvList;
            }
        }

        private void editTeamTS_Click(object sender, EventArgs e)
        {
            var teams = new LoadTeamDataForm(this);
            teams.Database.TeamList = _databaseGame.TeamList;
            teams.ShowDialog();
            if (teams.IsDisposed)
            {
                if (teams.Database.TeamList != null)
                {
                    _databaseGame.TeamList = teams.Database.TeamList;
                    TeamsDBT1.DataSource = null;
                    TeamsDBT1.DataSource = _databaseGame.TeamList;
                    TeamsDBT2.BindingContext = new BindingContext();
                    TeamsDBT2.DataSource = null;
                    TeamsDBT2.DataSource = _databaseGame.TeamList;
                }
            }
        }

        private void SetFromDBT1_Click(object sender, EventArgs e)
        {
            if (_databaseGame != null && !String.IsNullOrWhiteSpace(TeamsDBT1.Text))
            {
                if (Equals(TeamsDBT1.Text,team2NameBox.Text))
                {
                    MessageBox.Show("Select different teams!", "Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string name = TeamsDBT1.Text;
                if (string.IsNullOrWhiteSpace(name)) return;
                Team selected = (Team) TeamsDBT1.SelectedItem;
                _team1 = selected;
                var empty = new Player() {Name = " ", Number = " "};
                _team1.Players.Add(empty);
                _matchStats.TeamStats[0].Name = _team1.Name;
                team1NameBox.Text = _team1.Name;
                _formScoreBoard.SetTeamName(true,_team1.Name);
                UploadLogo(true,_team1.LogoPath);
                videoPath1.Text = _team1.VideoPath;
            }
            else
            {
                MessageBox.Show("Database not connected", "Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SetFromDBT2_Click(object sender, EventArgs e)
        {
            if (_databaseGame != null && !String.IsNullOrWhiteSpace(TeamsDBT2.Text))
            {
                if (Equals(team1NameBox.Text,TeamsDBT2.Text))
                {
                    MessageBox.Show("Select different teams!", "Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Team selected = (Team) TeamsDBT2.SelectedItem;
                if (selected == null) return; 
                _team2 = selected;
                var empty = new Player() {Name = " ", Number = " "};
                _team2.Players.Add(empty);
                _matchStats.TeamStats[1].Name = _team2.Name;
                team2NameBox.Text =  _matchStats.TeamStats[1].Name;
                _formScoreBoard.SetTeamName(false,  _team2.Name);
                UploadLogo(false, _team2.LogoPath);
                videoPath2.Text = _team2.VideoPath;
            }
            else
            {
                MessageBox.Show("Database not connected", "Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayVideo(string parPath)
        {
            if (File.Exists(parPath))
            {
                //_videoPlayerForm = new VideoPlayerForm();
                _videoPlayerForm.VideoPath = parPath;
                _videoPlayerForm.Show();
                _videoPlayerForm.PlayVideo();
                _videoPlayerForm.TopMost = true;
            }
            else
            {
                MessageBox.Show(@"File not found! Please select proper path to file!" , @"Video player path not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopVideo()
        {
            if (_videoPlayerForm == null) return;

            if (!_videoPlayerForm.IsDisposed)
            {
                _videoPlayerForm.MediaPlayer.close();
                _videoPlayerForm.Hide();
                _videoPlayerForm.TopMost = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Advertisment selected = (Advertisment)adsDBV.SelectedItem;
            if (selected != null && File.Exists(selected.Path))
            {
                PlayVideo(selected.Path);
            }
            else
            {
                MessageBox.Show(@"File not found! Please select proper path to file!" , @"Video player path not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopVideo();
        }

        private void playVideo1_Click(object sender, EventArgs e)
        {
            PlayVideo(videoPath1.Text);
        }

        private void cancelVideo1_Click(object sender, EventArgs e)
        {
            StopVideo();
        }

        private void uploadVideoT2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Video Files(*.mp4)|*.mp4";  
            open.InitialDirectory = Environment.CurrentDirectory+ "\\Videos\\Intro";
            if (open.ShowDialog() == DialogResult.OK) {
                //if (_videoPlayerForm == null) _videoPlayerForm = new VideoPlayerForm();
                _videoPlayerForm.VideoPath = open.FileName;
                videoPath2.Text = _videoPlayerForm.VideoPath;
            }
        }

        private void uploadVideoT1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Video Files(*.mp4)|*.mp4";  
            open.InitialDirectory = Environment.CurrentDirectory+ "\\Videos\\Intro";
            if (open.ShowDialog() == DialogResult.OK) {
                //if (_videoPlayerForm == null) _videoPlayerForm = new VideoPlayerForm();
                _videoPlayerForm.VideoPath = open.FileName;
                videoPath1.Text = _videoPlayerForm.VideoPath;
            }
        }

        private void playVideo2_Click(object sender, EventArgs e)
        {
            PlayVideo(videoPath2.Text);
        }

        private void cancelVideo2_Click(object sender, EventArgs e)
        {
            StopVideo();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextReader textReader = null;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "xml files (*.xml)|*.xml";
                open.InitialDirectory = Environment.CurrentDirectory+ "\\DB";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Database));
                    textReader = new StreamReader(open.FileName);
                    _databaseGame = (Database)deserializer.Deserialize(textReader);
                }
            }
            catch (Exception ex)
            {
                _databaseGame = new Database();
                MessageBox.Show(ex.Message, "nazovProgramuString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textReader != null)
                    textReader.Close();
                if (_databaseGame != null)
                {
                    _databaseGame.PostLoad();
                    TeamsDBT1.DataSource = _databaseGame.TeamList;
                    TeamsDBT1.SelectedItem = _databaseGame.TeamList[0];
                    TeamsDBT2.BindingContext = new BindingContext();
                    TeamsDBT2.DataSource = _databaseGame.TeamList;
                    TeamsDBT2.SelectedItem = _databaseGame.TeamList[1];
                    adsDBV.DataSource = null;
                    adsDBV.DataSource = _databaseGame.AdvList;
                }
                
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory+ "\\DB";
            TextWriter textWriter = null;

            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Database));
                    textWriter = new StreamWriter(saveFileDialog1.FileName);
                    serializer.Serialize(textWriter, _databaseGame);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "nazovProgramuString", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textWriter != null)
                    textWriter.Close();
            }
        }

        private void dropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _databaseGame = new Database();
            TeamsDBT1.DataSource = null;
            _matchStats.TeamStats[0].Name = null;
            videoPath1.Text =null;
            team1NameBox.Text = null;
            logo1Path.Text = null;
            _formScoreBoard.SetTeamName(true, _matchStats.TeamStats[0].Name);
            logo1.Dispose();
            TeamsDBT2.DataSource =  null;
            _matchStats.TeamStats[1].Name = null;
            videoPath2.Text =null;
            team2NameBox.Text = null;
            logo2Path.Text = null;
            adsDBV.DataSource = null;
            _formScoreBoard.SetTeamName(false, _matchStats.TeamStats[1].Name);
            logo2.Dispose();
            InitBoards();
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ads = new LoadAds(this);
            ads.Database.AdvList = _databaseGame.AdvList;
            ads.ShowDialog();
            if (ads.IsDisposed)
            {
                if (ads.Database.AdvList != null)
                {
                    _databaseGame.AdvList = ads.Database.AdvList;
                    adsDBV.DataSource = null;
                    adsDBV.DataSource = _databaseGame.AdvList;
                }
            }
        }

        private void videoPath1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            videoPath1.SelectAll();
        }

        private void videoPath2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            videoPath2.SelectAll();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gameTimes.Show();
        }

        private void plusShotsT1_Click(object sender, EventArgs e)
        {
            _matchStats.TeamStats[0].Shots++;
            _formScoreBoard.SetShots(true,_matchStats.TeamStats[0].Shots);
            shotsT1.Text = _matchStats.TeamStats[0].Shots.ToString();
        }

        private void plusShotsT2_Click(object sender, EventArgs e)
        {
            _matchStats.TeamStats[1].Shots++;
            _formScoreBoard.SetShots(false,_matchStats.TeamStats[1].Shots);
            shotsT2.Text = _matchStats.TeamStats[1].Shots.ToString();
        }

        private void plusFaceoffsT1_Click(object sender, EventArgs e)
        {
            if (!_timer.Enabled && !_breakRunning)
            {
                _matchStats.TeamStats[0].FaceOffs++;
                _formScoreBoard.SetFaceOff(true,_matchStats.TeamStats[0].FaceOffs);
                faceoffsT1.Text = _matchStats.TeamStats[0].FaceOffs.ToString();

                _matchStats.CreateFaceOffEvent(1,_elapsedTime);
                StartTimer();
            }
        }

        private void plusFaceoffsT2_Click(object sender, EventArgs e)
        {
            if (!_timer.Enabled && !_breakRunning)
            {
                var t1 = _matchTime;
                var t2 = _gameTimes.PeriodLength;
                t2.SubtractTime(t1);

                _matchStats.TeamStats[1].FaceOffs++;
                _formScoreBoard.SetFaceOff(false,_matchStats.TeamStats[1].FaceOffs);
                faceoffsT2.Text = _matchStats.TeamStats[1].FaceOffs.ToString();

                _matchStats.CreateFaceOffEvent(2,_elapsedTime);
                StartTimer();
            }
        }

        private void minusShotsT1_Click(object sender, EventArgs e)
        {
            if (_matchStats.TeamStats[0].Shots > 0)
            {
                _matchStats.TeamStats[0].Shots --;
                _formScoreBoard.SetShots(true,_matchStats.TeamStats[0].Shots);
                shotsT1.Text = _matchStats.TeamStats[0].Shots.ToString();
            }
        }

        private void minusFaceoffsT1_Click(object sender, EventArgs e)
        {
            if (_matchStats.TeamStats[0].FaceOffs > 0)
            {
                _matchStats.TeamStats[0].FaceOffs --;
                _formScoreBoard.SetFaceOff(true,_matchStats.TeamStats[0].FaceOffs);
                faceoffsT1.Text = _matchStats.TeamStats[0].FaceOffs.ToString();
            }
        }

        private void minusShotsT2_Click(object sender, EventArgs e)
        {
            if (_matchStats.TeamStats[1].Shots > 0)
            {
                _matchStats.TeamStats[1].Shots --;
                _formScoreBoard.SetShots(false,_matchStats.TeamStats[1].Shots);
                shotsT2.Text = _matchStats.TeamStats[1].Shots.ToString();
            }
        }

        private void minusFaceoffsT2_Click(object sender, EventArgs e)
        {
            if (_matchStats.TeamStats[1].FaceOffs > 0)
            {
                _matchStats.TeamStats[1].FaceOffs --;
                _formScoreBoard.SetFaceOff(false,_matchStats.TeamStats[1].FaceOffs);
                faceoffsT2.Text = _matchStats.TeamStats[1].FaceOffs.ToString();
            }
        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (_controlForm == null || _controlForm.IsDisposed)
                {
                    _controlForm = new ControlForm(_formScoreBoard);
                }
                _controlForm.ControlImport();
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (_controlForm == null || _controlForm.IsDisposed) 
                {
                    _controlForm = new ControlForm(_formScoreBoard);
                }
                _controlForm.ControlExport();
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setPT1P1_Click(object sender, EventArgs e)
        {
            SetPenalty(1);
        }

        private void setPT1P2_Click(object sender, EventArgs e)
        {
           SetPenalty(2);
        }

        private void setT2P1_Click(object sender, EventArgs e)
        {
            SetPenalty(3);
        }

        private void setT2P2_Click(object sender, EventArgs e)
        {
            SetPenalty(4);
        }

        private void SetPenalty(int position)
        {
            StopTime();
            var players = new List<Player>();

            if (position < 3 && _team1 != null)
            {
                players = _team1.Players;
            }
            else if (position > 2 && _team2 != null)
            {
                players = _team2.Players;
            }

            var form = new SetPenaltyForm(_gameTimes, players);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                switch (position)
                {
                    case 1:
                        for (int i = 0; i < _penalty[0].Length; i++)
                        {
                            _penalty[0][i] =  form.Penalty[i];
                        }
                        _matchStats.CreatePenaltyEvent(1,new Time() {Minutes =form.Penalty[1], Seconds = form.Penalty[2]});
                        _activePenalty[0] = true;
                        break;
                    case 2:
                        for (int i = 0; i < _penalty[0].Length; i++)
                        {
                            _penalty[1][i] =  form.Penalty[i];
                        }
                        _matchStats.CreatePenaltyEvent(1,new Time() {Minutes =form.Penalty[1], Seconds = form.Penalty[2]});
                        _activePenalty[1] = true;
                        break;
                    case 3:
                        for (int i = 0; i < _penalty[0].Length; i++)
                        {
                            _penalty[2][i] =  form.Penalty[i];
                        }
                        _matchStats.CreatePenaltyEvent(2,new Time() {Minutes =form.Penalty[1], Seconds = form.Penalty[2]});
                        _activePenalty[2] = true;
                        break;
                    case 4:
                        for (int i = 0; i < _penalty[0].Length; i++)
                        {
                            _penalty[3][i] =  form.Penalty[i];
                        }
                        _matchStats.CreatePenaltyEvent(2,new Time() {Minutes =form.Penalty[1], Seconds = form.Penalty[2]});
                        _activePenalty[3] = true;
                        break;
                }
                InitBoards();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SelectStats(bool[] parStats)
        {
            if (!parStats[0])
            {
                startTimeoutT1.Hide();
                startTimeoutT2.Hide();
                cancelTimeoutT1.Hide();
                cancelTimeoutT2.Hide();
            }
            else
            {
                startTimeoutT1.Show();
                startTimeoutT2.Show();
                cancelTimeoutT1.Show();
                cancelTimeoutT2.Show();
            }

            if (!parStats[1])
            {
                minusFaceoffsT1.Hide();
                minusFaceoffsT2.Hide();
                plusFaceoffsT1.Hide();
                plusFaceoffsT2.Hide();
            }
            else
            {
                minusFaceoffsT1.Show();
                minusFaceoffsT2.Show();
                plusFaceoffsT1.Show();
                plusFaceoffsT2.Show();
            }

            if (!parStats[2])
            {
                minusShotsT1.Hide();
                minusShotsT2.Hide();
                plusShotsT1.Hide();
                plusShotsT2.Hide();
            }
            else
            {
                minusShotsT1.Show();
                minusShotsT2.Show();
                plusShotsT1.Show();
                plusShotsT2.Show();
            }
        }

        private void selectStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                _statSettings.ShowDialog();
                if (_statSettings.DialogResult == DialogResult.OK)
                {
                    SelectStats(_statSettings.ActiveStatistics);
                    _formScoreBoard.SelectStats(_statSettings.ActiveStatistics);
                }
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_matchStats != null)
            {
                _exportSettings.ShowDialog();
                if (_exportSettings.DialogResult == DialogResult.OK)
                {
                    _matchStats.ExportEvents = _exportSettings.Export;
                    _matchStats.ExpoPath = _exportSettings.Path;
                }
            }
        }

        private void shootoutBtn_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (_timer.Enabled) return;
                _matchTime = new Time() {Minutes = 0, Seconds = 0};
                period.Text = "SH";
                _formScoreBoard.SetPeriod("SH");
                _formScoreBoard.SetTime(_matchTime);
                UpdateTime(_matchTime);
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void overTBreak_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (!_timer.Enabled)
                {
                    _matchTime = _gameTimes.BreakOvertLength;
                    _breakRunning = true;
                    period.Text = "OB";
                    _formScoreBoard.SetPeriod("OB");
                    _formScoreBoard.SetTime(_matchTime);
                    UpdateTime(_matchTime);
                }
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void preMatchCount_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (_timer.Enabled) return;
                _matchTime = _gameTimes.PreMatchTime;
                period.Text = " ";
                _formScoreBoard.SetPeriod(" ");
                _formScoreBoard.SetTime(_matchTime);
                UpdateTime(_matchTime);
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void overT1_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (!_timer.Enabled)
                {
                    _matchTime = _gameTimes.PeriodOvertLength;
                    _breakRunning = true;
                    period.Text = "O1";
                    _formScoreBoard.SetPeriod("O1");
                    _formScoreBoard.SetTime(_matchTime);
                    UpdateTime(_matchTime);
                }
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void overT2_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (!_timer.Enabled)
                {
                    _matchTime = _gameTimes.PeriodOvertLength;
                    _breakRunning = true;
                    period.Text = "O2";
                    _formScoreBoard.SetPeriod("O2");
                    _formScoreBoard.SetTime(_matchTime);
                    UpdateTime(_matchTime);
                }
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_formScoreBoard.IsActive)
            {
                if (_controlForm == null || _controlForm.IsDisposed) _controlForm = new ControlForm(_formScoreBoard);
                _controlForm.Show();
                _controlForm.BringToFront();
            }
            else
            {
                MessageBox.Show(@"You have to create scoreboard at first!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void auxiliaryDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serial = new SerialPortSettings();
            serial.Show();
        }

        private void customEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new ManualEvent();
            help.ShowDialog();
            if (help.DialogResult == DialogResult.OK)
            {
                _matchStats.CreateManualEvent(help.Description,help.Name);
            }
        }
    }
}
