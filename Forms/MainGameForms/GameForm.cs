using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes;
using Scoreboard.Classes.Database;
using Scoreboard.Classes.GameStatistics;
using Scoreboard.Forms.DBForms;
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

        private Team _team1;
        private Team _team2;
        private int _team1Goals = 0;
        private int _team2Goals =0;
        private int _period = 1;
        private string _team1Name = "Team1";
        private string _team2Name = "Team2";
        private int _secondsT = 0;
        private int _minutesT = 0;

        private bool _breakRunning = false;
        private bool _periodEnd = false;

        private int[][] _penalty;
        private int[][] _timeouts;

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
            _matchStats = new MatchStatistics(_team1Name, _team2Name);

            InitializeComponent();
            _formScoreBoard = parFormScoreBoard;
            SetTime(_gameTimes.PeriodLength.Minutes,_gameTimes.PeriodLength.Seconds);
            _timer = ResetTimer();
            _timerPenalty = ResetTimer();
            _timeoutTimer = ResetTimer();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            _formScoreBoard.SetTime(_minutesT, _secondsT);
            UpdateTime(_minutesT,_secondsT);
            _penalty = new int[MaxPenalties][];
            for (int i = 0; i < MaxPenalties; i++)
            {
                _penalty[i] = new int[3];
            }

            _timeouts = new int[TwoTeams][];
            for (int i = 0; i < _timeouts.Length; i++)
            {
                _timeouts[i] = new int[2];
                SetTimeoutLength(i+1,_gameTimes.TimeoutLength.Minutes,_gameTimes.TimeoutLength.Seconds);
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
            minutesTime.Text = _minutesT.ToString();
            secondsTime.Text = _secondsT.ToString();
            _formScoreBoard.SetTime(_minutesT,_secondsT);
            goalsTeam1.Text = _team1Goals.ToString();
            _formScoreBoard.SetGoal(true,_team1Goals);
            goalsTeam2.Text = _team2Goals.ToString();
            _formScoreBoard.SetGoal(false,_team1Goals);
            for (int i = 0; i < _penalty.Length; i++)
            {
                UpdatePenaltyGf(i+1,_penalty[i][0],_penalty[i][1],_penalty[i][2]);
                _formScoreBoard.SetPenalty(i+1,_penalty[i][0],_penalty[i][1],_penalty[i][2]);
            }
            for (int i = 0; i < _timeouts.Length; i++)
            {
                UpdateTimeoutGf(i+1,_timeouts[i][0],_timeouts[i][1]);
                _formScoreBoard.SetTimeout(i+1,_timeouts[i][0],_timeouts[i][1]);

            }
        }

        public void SetTimeoutLength(int team, int minutes, int seconds)
        {
            _timeouts[team-1][0] = minutes;
            _timeouts[team-1][1] = seconds;
            _formScoreBoard.SetTimeout(team,minutes,seconds);
            UpdateTimeoutGf(team,minutes,seconds);

        }

        public void SetTime(int minutes, int seconds)
        {
            _minutesT = minutes;
            _secondsT = seconds;
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
                _formScoreBoard.SetGoal(true,_team1Goals);
                goalsTeam1.Text = _team1Goals.ToString();
            }
        }

        private void GoalSelectPlayer(int team)
        {
            var t1 = new Time() {Minutes = _minutesT, Seconds = _secondsT};
            var t2 = _gameTimes.PeriodLength;
            t2.SubtractTime(t1);
            if (team == 1)
            {
                if (_team1 == null) return;
                SelectPlayerGoal varGoal = new SelectPlayerGoal(1, _matchStats, _team1.Players,t2);
                varGoal.Show();
            }
            if (team == 2)
            {
                if (_team2 == null) return;
                SelectPlayerGoal varGoal = new SelectPlayerGoal(2, _matchStats, _team2.Players,t2);
                varGoal.Show();
            }
        }

        private void plusGoal1_Click(object sender, EventArgs e)
        {
            StopTime();
            _team1Goals ++;
            _formScoreBoard.SetGoal(true,_team1Goals);
            goalsTeam1.Text = _team1Goals.ToString();
            GoalSelectPlayer(1);
        }

        private void minusGoal2_Click(object sender, EventArgs e)
        {
            if (_team2Goals > 0)
            {
                _team2Goals --;
                _formScoreBoard.SetGoal(false,_team2Goals);
                goalsTeam2.Text = _team2Goals.ToString();
            }
        }

        private void plusGoal2_Click(object sender, EventArgs e)
        {
            StopTime();
            _team2Goals ++;
            _formScoreBoard.SetGoal(false,_team2Goals);
            goalsTeam2.Text = _team2Goals.ToString();
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

        private void setTeam1Name_Click(object sender, EventArgs e)
        {
            if (team1NameBox.Text.Length > 0)
            {
                _team1Name = team1NameBox.Text;
            }
            else
            {
                _team1Name = "Team1";
            }
            _formScoreBoard.SetTeamName(true,_team1Name);
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

        private void setTeam2Name_Click_1(object sender, EventArgs e)
        {
            if (team2NameBox.Text.Length > 0)
            {
                _team2Name = team2NameBox.Text;
            }
            else
            {
                _team2Name = "Team2";
            }
            _formScoreBoard.SetTeamName(false, _team2Name);
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
            if (!_timer.Enabled && !_periodEnd && (_minutesT > 0 || _secondsT > 0) && (!_timeoutTimer.Enabled))
            {
                _timer = ResetTimer();
                _timer.Tick += DisplayTimeTimer;
                _timer.Enabled = true;
                _timer.Start();
                _matchStats.CreateStartPeriodEvent(_period);
                StartPenalty();
            }
        }

        private void startTime_Click(object sender, EventArgs e)
        {
            StartTimer();
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
                StopTime();
                _timer.Enabled = false;
                if (!_periodEnd)
                {
                    _periodEnd = true;
                    MessageBox.Show(@"Period ended" , @"Timer stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _breakRunning = false;
                    _periodEnd = false;
                    _period++;
                    SetTime(_gameTimes.PeriodLength.Minutes,_gameTimes.PeriodLength.Seconds);
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
            _minutesT = _gameTimes.PeriodLength.Minutes;
            _secondsT = _gameTimes.PeriodLength.Seconds;
            _timer.Enabled = false;
            _periodEnd = false;
            InitBoards();
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
                _formScoreBoard.Dispose();
                _formScoreBoard.ResetInstance();
                _formScoreBoard.IsActive = false;
            }
        }

        private void closeScoreboardBtn_Click(object sender, EventArgs e)
        {
            CloseScoreBoard();
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

        private void startTimeoutT1_Click(object sender, EventArgs e)
        {
            if (!_timeoutTimer.Enabled && (_timeouts[0][0] > 0 || _timeouts[0][1] > 0) && !_breakRunning)
            {
                StartTimeout(1);
                _timeoutTimer.Enabled = true;
            }
        }
        private void startTimeoutT2_Click(object sender, EventArgs e)
        {
            if (!_timeoutTimer.Enabled && (_timeouts[1][0] > 0 || _timeouts[1][1] > 0) && !_breakRunning)
            {
                StartTimeout(2);
                _timeoutTimer.Enabled = true;
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
            if (_timeouts[team-1][1] == 0)
            {
                if (_timeouts[team-1][0] > 0)
                {
                    _timeouts[team-1][0]--;
                    _timeouts[team-1][1] = 60;
                    _timeouts[team-1][1]--;
                }
            }
            else
            {
                _timeouts[team-1][1]--;
            }

            _formScoreBoard.SetTimeout(team,_timeouts[team-1][0],_timeouts[team-1][1]);
            UpdateTimeoutGf(team,_timeouts[team-1][0],_timeouts[team-1][1]);
            

            if (_timeouts[team-1][0] == 0 && _timeouts[team-1][1] == 0)
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
            if (_timeoutTimer.Enabled)
            {
                _timeoutTimer.Stop();
                SetTimeoutLength(1,_gameTimes.TimeoutLength.Minutes,_gameTimes.TimeoutLength.Seconds);
                _timeoutTimer.Enabled = false;
            }
        }

        private void cancelTimeoutT2_Click(object sender, EventArgs e)
        {
            if (_timeoutTimer.Enabled)
            {
                _timeoutTimer.Stop();
                SetTimeoutLength(2,_gameTimes.TimeoutLength.Minutes,_gameTimes.TimeoutLength.Seconds);
                _timeoutTimer.Enabled = false;
            }
        }

        private void startBreak_Click(object sender, EventArgs e)
        {
            if (_periodEnd && !_breakRunning && !_timer.Enabled && (_period < 3))
            {
                _minutesT = _gameTimes.BreakLength.Minutes;
                _secondsT = _gameTimes.BreakLength.Seconds;
                _timer = ResetTimer();
                _timer.Tick += DisplayTimeTimer;
                _timer.Enabled = true;
                _timer.Start();
                _breakRunning = true;
                period.Text = "B";
                _formScoreBoard.SetPeriod("B");
                _formScoreBoard.SetTime(_minutesT,_secondsT);
                UpdateTime(_minutesT,_secondsT);
            }
        }

        private void cancelBreak_Click(object sender, EventArgs e)
        {
            if (_breakRunning && _timer.Enabled)
            {
                _timer.Stop();
                _minutesT = _gameTimes.BreakLength.Minutes;
                _secondsT = _gameTimes.BreakLength.Seconds;
                _breakRunning = false;
                _timer.Enabled = false;
                _formScoreBoard.SetTime(_minutesT,_secondsT);
                UpdateTime(_minutesT,_secondsT);
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
                if (Equals(TeamsDBT1.Text,TeamsDBT2.Text))
                {
                    MessageBox.Show("Select different teams!", "Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string name = TeamsDBT1.Text;
                if (string.IsNullOrWhiteSpace(name)) return;
                Team selected = (Team) TeamsDBT1.SelectedItem;
                _team1 = selected;
                _matchStats.TeamStats[0].Name = _team1.Name;
                _team1Name = name;
                team1NameBox.Text = _team1Name;
                _formScoreBoard.SetTeamName(true,_team1Name);
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
                if (Equals(TeamsDBT1.Text,TeamsDBT2.Text))
                {
                    MessageBox.Show("Select different teams!", "Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Team selected = (Team) TeamsDBT2.SelectedItem;
                if (selected == null) return; 
                _team2Name = selected.Name;
                team2NameBox.Text = _team2Name;
                _formScoreBoard.SetTeamName(false, _team2Name);
                UploadLogo(false, selected.LogoPath);
                videoPath2.Text = selected.VideoPath;
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
            _team1Name = null;
            videoPath1.Text =null;
            team1NameBox.Text = null;
            logo1Path.Text = null;
            _formScoreBoard.SetTeamName(true,_team1Name);
            logo1.Dispose();
            TeamsDBT2.DataSource =  null;
            _team2Name = null;
            videoPath2.Text =null;
            team2NameBox.Text = null;
            logo2Path.Text = null;
            adsDBV.DataSource = null;
            _formScoreBoard.SetTeamName(false,_team2Name);
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
            _matchStats.TeamStats[0].FaceOffs++;
            _formScoreBoard.SetFaceOff(true,_matchStats.TeamStats[0].FaceOffs);
            faceoffsT1.Text = _matchStats.TeamStats[0].FaceOffs.ToString();
        }

        private void plusFaceoffsT2_Click(object sender, EventArgs e)
        {
            _matchStats.TeamStats[1].FaceOffs++;
            _formScoreBoard.SetFaceOff(false,_matchStats.TeamStats[1].FaceOffs);
            faceoffsT2.Text = _matchStats.TeamStats[1].FaceOffs.ToString();
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
        }
    }
}
