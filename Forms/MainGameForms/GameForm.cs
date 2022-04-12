using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Scoreboard.Classes;
using Scoreboard.Classes.AuxiliaryDevices;
using Scoreboard.Classes.Database;
using Scoreboard.Classes.GameStatistics;
using Scoreboard.Forms.Appearance;
using Scoreboard.Forms.AppSettings;
using Scoreboard.Forms.DBForms;
using Scoreboard.Forms.Statistics;

namespace Scoreboard.Forms.MainGameForms;

// this is main form of our application 
// it is displayed right after application start
// contains menu with all of its options for users
// some of these form are created right after this form is created, others are created only locally in specific methods and functions
// also team statistics, times and timers are part of this form
// database is also stored as class property
// all of data displayed on GameForm are mirrored on scoreboard so user can easily see all of data displayed on Scoreboard
// it holds all of controls which are needed to control this app
// creating minute by minute export are done form specific methods here, like when goal plus was clicked, face offs plus clicked,...
// siren activation with specific sounds are also called from after specific actions occur in this class
public partial class GameForm : Form
{
    private const int MaxPenalties = 4;
    private const int TwoTeams = 2;
    private const int MinPlayers = 1;

    private readonly StatisticsSettings _statSettings;
    private readonly ExportStatsForm _exportSettings;
    private readonly VideoPlayerForm _videoPlayerForm;
    private readonly SetTimes _gameTimes;
    private readonly MatchStatistics _matchStats;
    private ScoreboardForm _formScoreBoard;
    private ControlForm _controlForm;
    private SerialPortSettings _serialDevices;

    private Team _team1;
    private Team _team2;
    private Time _matchTime;
    private Time _elapsedTime;
    private Timer _timer;
    private Timer _timerPenalty;
    private Timer _timeoutTimer;

    private int _period = 1;

    private bool _specialTime;
    private bool _breakRunning;
    private bool _periodEnd;
    private bool _periodStarted;
    private bool _timeout1Running;
    private bool _timeout2Running;
    private bool[] _activePenalty;

    private int[][] _penalty;
    private Time[] _timeouts;

    public Database DatabaseGame { get; private set; }

    public GameForm(ScoreboardForm parFormScoreBoard)
    {
        if (Screen.AllScreens.Length >= 2) _videoPlayerForm = new VideoPlayerForm();
        DatabaseGame = new Database();
        _gameTimes = new SetTimes(this);
        _matchStats = new MatchStatistics("Team1", "Team2");
        _statSettings = new StatisticsSettings();
        _exportSettings = new ExportStatsForm();
        _serialDevices = new SerialPortSettings();
            

        InitializeComponent();
        _formScoreBoard = parFormScoreBoard;
        SetTime(_gameTimes.PeriodLength);
        _timer = ResetTimer();
        _timerPenalty = ResetTimer();
        _timeoutTimer = ResetTimer();
        StartPosition=FormStartPosition.CenterScreen;
    }

    private void GameFormLoad(object parSender, EventArgs parE)
    {
        _formScoreBoard.SetTime(_matchTime);
        UpdateTime(_matchTime);
        _penalty = new int[MaxPenalties][];
        _activePenalty = new bool[MaxPenalties];
        for (var i = 0; i < MaxPenalties; i++)
        {
            _penalty[i] = new int[3];
            _activePenalty[i] = false;
        }

        _timeouts = new Time[TwoTeams];
        for (var i = 0; i < _timeouts.Length; i++)
        {
            SetTimeoutLength(i + 1, _gameTimes.TimeoutLength);
        }

        InitBoards();
    }

    private static Timer ResetTimer()
    {
        return new Timer { Interval = 1000 };
    }

    // initializes all data displayed on game-form and also on scoreboard
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
        shotsT1.Text = _matchStats.TeamStats[0].Shots.ToString();
        _formScoreBoard.SetShots(true,_matchStats.TeamStats[0].Shots);
        faceoffsT1.Text = _matchStats.TeamStats[0].FaceOffs.ToString();
        _formScoreBoard.SetFaceOff(true,_matchStats.TeamStats[0].FaceOffs);
        shotsT2.Text = _matchStats.TeamStats[1].Shots.ToString();
        _formScoreBoard.SetShots(false,_matchStats.TeamStats[1].Shots);
        faceoffsT2.Text = _matchStats.TeamStats[1].FaceOffs.ToString();
        _formScoreBoard.SetFaceOff(false,_matchStats.TeamStats[1].FaceOffs);

        for (var i = 0; i < _penalty.Length; i++)
        {
            UpdatePenaltyGf(i+1,_penalty[i][1],_penalty[i][2]);
            _formScoreBoard.SetPenalty(i+1,_penalty[i][0],_penalty[i][1],_penalty[i][2]);
        }
        for (var i = 0; i < _timeouts.Length; i++)
        {
            UpdateTimeoutGf(i+1);
            _formScoreBoard.SetTimeout(i+1,_timeouts[i]);
        }
    }

    public void SetTimeoutLength(int parTeam, Time parTime)
    {
        _timeouts[parTeam - 1] = parTime;
        _formScoreBoard.SetTimeout(parTeam,parTime);
        UpdateTimeoutGf(parTeam);
    }

    public void SetTime(Time parTime)
    {
        _matchTime = parTime;
    }

    private void UpdateTimeoutGf(int parTeam)
    {
        switch (parTeam)
        {
            case 1:
                timeoutT1M.Text = _timeouts[parTeam - 1].Minutes.ToString();
                timeoutT1S.Text = _timeouts[parTeam - 1].Seconds.ToString();
                break;
            case 2:
                timeoutT2M.Text = _timeouts[parTeam - 1].Minutes.ToString();
                timeoutT2S.Text = _timeouts[parTeam - 1].Seconds.ToString();
                break;
        }
    }

    // if team is selected and has enough players, shows select player dialog to select assistance and player which scored
    private void GoalSelectPlayer(int parTeam)
    {
        switch (parTeam)
        {
            case 1 when _team1 == null || _team1.Players.Count < MinPlayers:
                return;
            case 1:
            {
                SelectPlayerGoal varGoal = new(1, _matchStats, _team1.Players,_elapsedTime);
                varGoal.ShowDialog();
                break;
            }
            case 2 when _team2 == null || _team2.Players.Count < MinPlayers:
                return;
            case 2:
            {
                SelectPlayerGoal varGoal = new(2, _matchStats, _team2.Players,_elapsedTime);
                varGoal.ShowDialog();
                break;
            }
        }
    }

    private void MinusGoal1Click(object parSender, EventArgs parE)
    {
        if (_matchStats.TeamStats[0].Goals <= 0) return;
        _matchStats.TeamStats[0].Goals --;
        _formScoreBoard.SetGoal(true,_matchStats.TeamStats[0].Goals);
        goalsTeam1.Text = _matchStats.TeamStats[0].Goals.ToString();
    }

    private void PlusGoal1Click(object parSender, EventArgs parE)
    {
        StopTime();
        _matchStats.TeamStats[0].Goals ++;
        _formScoreBoard.SetGoal(true,_matchStats.TeamStats[0].Goals);
        goalsTeam1.Text = _matchStats.TeamStats[0].Goals.ToString();
        GoalSelectPlayer(1);
        _serialDevices.SirenStart(SirenType.Disrupted);
    }

    private void MinusGoal2Click(object parSender, EventArgs parE)
    {
        if (_matchStats.TeamStats[1].Goals <= 0) return;
        _matchStats.TeamStats[1].Goals --;
        _formScoreBoard.SetGoal(false,_matchStats.TeamStats[1].Goals);
        goalsTeam2.Text = _matchStats.TeamStats[1].Goals.ToString();
    }

    private void PlusGoal2Click(object parSender, EventArgs parE)
    {
        StopTime();
        _matchStats.TeamStats[1].Goals ++;
        _formScoreBoard.SetGoal(false,_matchStats.TeamStats[1].Goals);
        goalsTeam2.Text = _matchStats.TeamStats[1].Goals.ToString();
        GoalSelectPlayer(2);
        _serialDevices.SirenStart(SirenType.Disrupted);
    }

    private void P1T1ShowPenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.ShowPenalty(1);
    }

    private void P2T1ShowPenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.ShowPenalty(2);
    }

    private void P1T1HidePenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.HidePenalty(1);
    }

    private void P2T1HidePenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.HidePenalty(2);
    }

    private void P1T2ShowPenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.ShowPenalty(3);
    }

    private void P2T2ShowPenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.ShowPenalty(4);
    }

    private void P1T2HidePenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.HidePenalty(3);
    }

    private void P2T2HidePenaltyClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.HidePenalty(4);
    }

    private void UpdatePeriod()
    {
        period.Text = _period.ToString();
        _formScoreBoard.SetPeriod(_period.ToString());
        _periodStarted = false;
    }

    private void PeriodMinusClick(object parSender, EventArgs parE)
    {
        if (_period <= 1) return;
        _period--;
        UpdatePeriod();
    }

    private void PeriodPlusClick(object parSender, EventArgs parE)
    {
        if (_period >= 3) return;
        _period++;
        UpdatePeriod();
    }

    private void UpdateTeam1Name()
    {
        if (team1NameBox.Text.Length > 0 && !Equals(team2NameBox.Text,team1NameBox.Text))
        {
            _matchStats.TeamStats[0].Name = team1NameBox.Text;
        }
        else
        {
            _matchStats.TeamStats[0].Name = "Team1";
            team1NameBox.Text = @"Team1";
        }
        _formScoreBoard.SetTeamName(true, _matchStats.TeamStats[0].Name);
    }

    private void SetTeam1NameClick(object parSender, EventArgs parE)
    {
        UpdateTeam1Name();
    }

    private void UploadLogo(bool parTeam1)
    {
        OpenFileDialog open = new();
        open.Filter = @"Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        if (open.ShowDialog() != DialogResult.OK) return;
        if (parTeam1)
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

    private void UploadLogo(bool parTeam1, string parPath)
    {
        if (parPath.Length == 0) return;

        if (parTeam1)
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

    private void UploadLogoT1Click(object parSender, EventArgs parE)
    {
        UploadLogo(true);
    }

    private void HideT1LogoClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.HideLogo(true);
    }

    private void ShowT1LogoClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.SetLogo(true, logo1.Image);
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
            team2NameBox.Text = @"Team2";
        }
        _formScoreBoard.SetTeamName(false,  _matchStats.TeamStats[1].Name);
    }

    private void SetTeam2NameClick1(object parSender, EventArgs parE)
    {
        UpdateTeam2Name();
    }

    private void UploadLogoT2Click(object parSender, EventArgs parE)
    {
        UploadLogo(false);
    }

    private void HideT2LogoClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.HideLogo(false);
    }

    private void ShowT2LogoClick(object parSender, EventArgs parE)
    {
        _formScoreBoard.SetLogo(false, logo2.Image);
        _formScoreBoard.ShowLogo(false);
    }

    // starts main timer
    private void StartTimer()
    {
        if (_timer.Enabled || _periodEnd || _matchTime.IsZero() || _timeoutTimer.Enabled) return;
        _timer = ResetTimer();
        _timer.Tick += DisplayTimeTimer;
        _timer.Enabled = true;
        _timer.Start();
        if (!_periodStarted)
        {
            if(!_specialTime) _matchStats.CreateStartPeriodEvent(_period, _elapsedTime);
            _periodStarted = true;
        }
        StartPenalty();
    }

    private void StartTimeClick(object parSender, EventArgs parE)
    {
        StartTimer();
    }

    // main timer method which updates times if all conditions are met
    // it depends on actual period / break
    // also counts elapsed time (elapsed time is not added if it is specialTime / break like overtime or timeout which would violate elapsed time)
    // if time is elapsed period is added and properties are re-set
    private void DisplayTimeTimer(object parMyObject, EventArgs parMyEventArgs)
    {
        _matchTime.TickMinus();
        if(!_specialTime && !_breakRunning) _elapsedTime.TickPlus();

        if (_matchTime.Minutes == 1 && _matchTime.Seconds == 0 && !_specialTime) _matchStats.CreateLastMinuteEvent(_period, _elapsedTime);

        _formScoreBoard.SetTime(_matchTime);
        UpdateTime(_matchTime);

        if (!_matchTime.IsZero()) return;
        StopTime();
        _timer.Enabled = false;
        if (!_periodEnd)
        {
            _periodEnd = true;
            _periodStarted = false;
            MessageBox.Show(@"Period ended" , @"Timer stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(!_specialTime) _matchStats.CreateEndPeriodEvent(_period, _elapsedTime);
            _specialTime = false;
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
        _serialDevices.SirenStart(SirenType.Disrupted);
    }

    private void StopTime()
    {
        if (!_timer.Enabled || _periodEnd) return;
        _timer.Stop();
        _timer.Enabled = false;
        StopPenalty();
    }

    private void StopTimeClick(object parSender, EventArgs parE)
    {
        StopTime();
    }

    private void ResetTimeClick(object parSender, EventArgs parE)
    {
        if (_timer.Enabled)
        {
            _timer.Stop();
        }
        _matchTime = _gameTimes.PeriodLength;
        _timer.Enabled = false;
        _periodEnd = false;
        _periodStarted = false;
        _specialTime = false;
        InitBoards();
    }

    private void UpdateTime(Time parTime)
    {
        minutesTime.Text = parTime.Minutes < 10 ? $@"0{parTime.Minutes}" : parTime.Minutes.ToString();

        secondsTime.Text = parTime.Seconds < 10 ? $@"0{parTime.Seconds}" : parTime.Seconds.ToString();
    }

    private void UpdatePenaltyGf(int parPosition, int parMinutes, int parSeconds)
    {
        var sMinutes = parMinutes < 10 ? $"0{parMinutes}" : parMinutes.ToString();

        var sSeconds = parSeconds < 10 ? $"0{parSeconds}" : parSeconds.ToString();

        switch (parPosition)
        {
            case 1:
                penP1T1.Text = _penalty[0][0].ToString();
                penMinP1T1.Text = sMinutes;
                penSecP1T1.Text = sSeconds;
                break;

            case 2:
                penP2T1.Text = _penalty[1][0].ToString();
                penMinP2T1.Text = sMinutes;
                penSecP2T1.Text = sSeconds;
                break;

            case 3:
                penP1T2.Text = _penalty[2][0].ToString();
                penMinP1T2.Text = sMinutes;
                penSecP1T2.Text = sSeconds;
                break;

            case 4:
                penP2T2.Text = _penalty[3][0].ToString();
                penMinP2T2.Text = sMinutes;
                penSecP2T2.Text = sSeconds;
                break;

            default:
                throw new ArgumentException("Index is out of range");
        }
    }

    private void ResetPenalty(int parPosition)
    {
        for (var i = 0; i < 3; i++)
        {
            _penalty[parPosition-1][i] = 0;
        }
        _formScoreBoard.SetPenalty(parPosition,_penalty[parPosition-1][0],_penalty[parPosition-1][1],_penalty[parPosition-1][2]);
        UpdatePenaltyGf(parPosition,_penalty[parPosition-1][1], _penalty[parPosition-1][2]);
    }

    private void ResetT1P1Click(object parSender, EventArgs parE)
    {
        ResetPenalty(1);
    }

    private void ResetT1P2Click(object parSender, EventArgs parE)
    {
        ResetPenalty(2);
    }

    private void ResetT2P1Click(object parSender, EventArgs parE)
    {
        ResetPenalty(3);
    }

    private void ResetT2P2Click(object parSender, EventArgs parE)
    {
        ResetPenalty(4);
    }

    private void StartPenalty()
    {
        if (_timerPenalty.Enabled || _periodEnd || !_timer.Enabled) return;
        _timerPenalty = ResetTimer();
        _timerPenalty.Tick += DisplayTimePenalty;
        _timerPenalty.Enabled = true;
        _timerPenalty.Start();
    }

    // counts penalty time for each penalty if penalty was set 
    // if elapsed penalty is hidden and event created
    private void DisplayTimePenalty(object parMyObject, EventArgs parMyEventArgs)
    {
        for (var i = 0; i < _penalty.Length; i++)
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
                UpdatePenaltyGf(i + 1, _penalty[i][1], _penalty[i][2]);
                _formScoreBoard.SetPenalty(i + 1, _penalty[i][0], _penalty[i][1], _penalty[i][2]);
            }
            else
            {
                _formScoreBoard.HidePenalty(i + 1);
                if (!_activePenalty[i]) continue;
                _matchStats.EndPenaltyEvent(i + 1, _elapsedTime);
                _activePenalty[i] = false;
            }
        }
    }

    private void StopPenalty()
    {
        if (!_timerPenalty.Enabled || _timer.Enabled) return;
        _timerPenalty.Stop();
        _timerPenalty.Enabled = false;
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

    private void CreateBtnClick(object parSender, EventArgs parE)
    {
        if (Screen.AllScreens.Length >= 2)
        {
            ShowScoreBoard();
        }
        else
        {
            MessageBox.Show(@"Connect second screen to your computer", @"Screen not found", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void CloseScoreBoard()
    {
        if (_formScoreBoard == null) return;
        _formScoreBoard.Dispose();
        _formScoreBoard.ResetInstance();
        _formScoreBoard.IsActive = false;
        if(_controlForm == null) return;
        if (_controlForm.BlackActive) _controlForm.BlackForm.Dispose();
    }

    private void CloseScoreboardBtnClick(object parSender, EventArgs parE)
    {
        CloseScoreBoard();
    }

    private void StartTimeoutT1Click(object parSender, EventArgs parE)
    {
        if (_timeoutTimer.Enabled || _timeouts[0].IsZero() || _breakRunning || _timeout1Running) return;
        StartTimeout(1);
        _timeoutTimer.Enabled = true;
        _timeout1Running = true;
        _matchStats.CreateTimeoutEvent(1,_elapsedTime);
        _serialDevices.SirenStart(SirenType.Short);
    }

    private void StartTimeoutT2Click(object parSender, EventArgs parE)
    {
        if (_timeoutTimer.Enabled || _timeouts[1].IsZero() || _breakRunning || _timeout2Running) return;
        StartTimeout(2);
        _timeoutTimer.Enabled = true;
        _timeout2Running = true;
        _matchStats.CreateTimeoutEvent(2,_elapsedTime);
        _serialDevices.SirenStart(SirenType.Short);
    }

    private void StartTimeout(int parTeam)
    {
        _timeoutTimer = ResetTimer();
        switch (parTeam)
        {
            case 1:
                _timeoutTimer.Tick += DisplayTimeTimeout1;
                break;
            case 2:
                _timeoutTimer.Tick += DisplayTimeTimeout2;
                break;
        }
        _timeoutTimer.Enabled = true;
        _timeoutTimer.Start();
        StopPenalty();
        StopTime();
        _timer.Enabled = false;
        _timerPenalty.Enabled = false;
    }

    // counts timeout for each team
    private void CountTimeout(int parTeam)
    {
        _timeouts[parTeam-1].TickMinus();


        _formScoreBoard.SetTimeout(parTeam,_timeouts[parTeam-1]);
        UpdateTimeoutGf(parTeam);


        if (!_timeouts[parTeam - 1].IsZero()) return;
        _timeoutTimer.Stop();
        switch (parTeam)
        {
            case 1:
            case 2:
                _timeoutTimer.Enabled = false;
                break;
        }
        MessageBox.Show(@"Timeout ended" , @"Timer stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
        _serialDevices.SirenStart(SirenType.Short);
    }

    private void DisplayTimeTimeout1(object parMyObject, EventArgs parMyEventArgs)
    {
        CountTimeout(1);
    }

    private void DisplayTimeTimeout2(object parMyObject, EventArgs parMyEventArgs)
    {
        CountTimeout(2);
    }

    private void CancelTimeoutT1Click(object parSender, EventArgs parE)
    {
        if (_timeouts[0].IsZero()) return;
        if (!_timeoutTimer.Enabled || !_timeout1Running) return;
        _timeoutTimer.Stop();
        SetTimeoutLength(1,_gameTimes.TimeoutLength);
        _timeoutTimer.Enabled = false;
        _timeout1Running = false;
    }

    private void CancelTimeoutT2Click(object parSender, EventArgs parE)
    {
        if(_timeouts[1].IsZero()) return;
        if (!_timeoutTimer.Enabled || !_timeout2Running) return;
        _timeoutTimer.Stop();
        SetTimeoutLength(2,_gameTimes.TimeoutLength);
        _timeoutTimer.Enabled = false;
        _timeout2Running = false;
    }

    private void StartBreakClick(object parSender, EventArgs parE)
    {
        if (!_periodEnd || _breakRunning || _timer.Enabled || _period >= 3) return;
        _matchTime = _gameTimes.BreakLength;
        _timer = ResetTimer();
        _timer.Tick += DisplayTimeTimer;
        _timer.Enabled = true;
        _timer.Start();
        _breakRunning = true;
        period.Text = @"B";
        _formScoreBoard.SetPeriod("B");
        _formScoreBoard.SetTime(_matchTime);
        UpdateTime(_matchTime);
        _serialDevices.SirenStart(SirenType.Short);
    }

    private void CancelBreakClick(object parSender, EventArgs parE)
    {
        if (!_breakRunning || !_timer.Enabled) return;
        _timer.Stop();
        _matchTime = _gameTimes.BreakLength;
        _breakRunning = false;
        _timer.Enabled = false;
        _formScoreBoard.SetTime(_matchTime);
        UpdateTime(_matchTime);
    }

    public void UpdateTeams(Database parDb)
    {
        if (parDb.TeamList != null)
        {
            DatabaseGame.TeamList = parDb.TeamList;
        }
    }

    public void UpdateAds(Database parDb)
    {
        if (parDb.AdvList != null)
        {
            DatabaseGame.AdvList = parDb.AdvList;
        }
    }

    private void EditTeamTsClick(object parSender, EventArgs parE)
    {
        var teams = new LoadTeamDataForm(this);
        teams.Database.TeamList = DatabaseGame.TeamList;
        teams.ShowDialog();
        if (!teams.IsDisposed) return;
        if (teams.Database.TeamList == null) return;
        DatabaseGame.TeamList = teams.Database.TeamList;
        TeamsDBT1.DataSource = null;
        TeamsDBT1.DataSource = DatabaseGame.TeamList;
        TeamsDBT2.BindingContext = new BindingContext();
        TeamsDBT2.DataSource = null;
        TeamsDBT2.DataSource = DatabaseGame.TeamList;
    }

    // sets team info about selected team from database to game-board team1 
    // and loads all data from DB
    private void SetFromDbt1Click(object parSender, EventArgs parE)
    {
        if (DatabaseGame != null && !string.IsNullOrWhiteSpace(TeamsDBT1.Text))
        {
            if (Equals(TeamsDBT1.Text,team2NameBox.Text))
            {
                MessageBox.Show(@"Select different teams!", @"Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var name = TeamsDBT1.Text;
            if (string.IsNullOrWhiteSpace(name)) return;
            var selected = (Team) TeamsDBT1.SelectedItem;
            _team1 = selected;
            var empty = new Player {Name = "", Number = ""};
            _team1.AddPlayer(empty);
            _matchStats.TeamStats[0].Name = _team1.Name;
            team1NameBox.Text = _team1.Name;
            _formScoreBoard.SetTeamName(true,_team1.Name);
            UploadLogo(true,_team1.LogoPath);
            videoPath1.Text = _team1.VideoPath;
            _formScoreBoard.ShowLogo(true);
        }
        else
        {
            MessageBox.Show(@"Database not connected", @"Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            
    }

    // sets team info about selected team from database to game-board team2 
    // and loads all data from DB
    private void SetFromDbt2Click(object parSender, EventArgs parE)
    {
        if (DatabaseGame != null && !string.IsNullOrWhiteSpace(TeamsDBT2.Text))
        {
            if (Equals(team1NameBox.Text,TeamsDBT2.Text))
            {
                MessageBox.Show(@"Select different teams!", @"Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selected = (Team) TeamsDBT2.SelectedItem;
            if (selected == null) return; 
            _team2 = selected;
            var empty = new Player {Name = "", Number = ""};
            _team2.AddPlayer(empty);
            _matchStats.TeamStats[1].Name = _team2.Name;
            team2NameBox.Text =  _matchStats.TeamStats[1].Name;
            _formScoreBoard.SetTeamName(false,  _team2.Name);
            UploadLogo(false, _team2.LogoPath);
            videoPath2.Text = _team2.VideoPath;
            _formScoreBoard.ShowLogo(false);
        }
        else
        {
            MessageBox.Show(@"Database not connected", @"Load from DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // plays video which path is set from parameter
    private void PlayVideo(string parPath)
    {
        if (File.Exists(parPath))
        {
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

        if (_videoPlayerForm.IsDisposed) return;
        _videoPlayerForm.MediaPlayer.close();
        _videoPlayerForm.Hide();
        _videoPlayerForm.TopMost = false;
    }

    // plays advertisement, if path is correct and also if advertisement is selected from box
    private void PlayAdClick(object parSender, EventArgs parE)
    {
        if (_videoPlayerForm == null)
        {
            MessageBox.Show(@"Please connect second screen to your computer and restart application. And try again." , @"Second screen not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selected = (Advertisement)adsDBV.SelectedItem;
        if (selected != null && File.Exists(selected.Path))
        {
            PlayVideo(selected.Path);
        }
        else
        {
            MessageBox.Show(@"File not found! Please select proper path to file!" , @"Video player path not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CancelAdClick(object parSender, EventArgs parE)
    {
        StopVideo();
    }

    private void PlayVideo1Click(object parSender, EventArgs parE)
    {
        if (_videoPlayerForm == null)
        {
            MessageBox.Show(@"Please connect second screen to your computer and restart application. And try again." , @"Second screen not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        PlayVideo(videoPath1.Text);
    }

    private void CancelVideo1Click(object parSender, EventArgs parE)
    {
        StopVideo();
    }

    private void UploadVideoT2Click(object parSender, EventArgs parE)
    {
        OpenFileDialog open = new();
        open.Filter = @"Video Files(*.mp4)|*.mp4";  
        open.InitialDirectory = $"{Environment.CurrentDirectory}\\Videos\\Intro";
        if (open.ShowDialog() != DialogResult.OK) return;
        _videoPlayerForm.VideoPath = open.FileName;
        videoPath2.Text = _videoPlayerForm.VideoPath;
    }

    private void UploadVideoT1Click(object parSender, EventArgs parE)
    {
        OpenFileDialog open = new();
        open.Filter = @"Video Files(*.mp4)|*.mp4";  
        open.InitialDirectory = $"{Environment.CurrentDirectory}\\Videos\\Intro";
        if (open.ShowDialog() != DialogResult.OK) return;
        _videoPlayerForm.VideoPath = open.FileName;
        videoPath1.Text = _videoPlayerForm.VideoPath;
    }

    private void PlayVideo2Click(object parSender, EventArgs parE)
    {
        if (_videoPlayerForm == null)
        {
            MessageBox.Show(@"Please connect second screen to your computer and restart application. And try again." , @"Second screen not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        PlayVideo(videoPath2.Text);
    }

    private void CancelVideo2Click(object parSender, EventArgs parE)
    {
        StopVideo();
    }

    // DB import method from xml
    private void ImportToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        TextReader textReader = null;
        try
        {
            OpenFileDialog open = new();
            open.Filter = @"xml files (*.xml)|*.xml";
            open.InitialDirectory = $"{Environment.CurrentDirectory}\\DB";
            if (open.ShowDialog() != DialogResult.OK) return;
            XmlSerializer deserializer = new(typeof(Database));
            textReader = new StreamReader(open.FileName);
            DatabaseGame = (Database)deserializer.Deserialize(textReader);
        }
        catch (Exception ex)
        {
            DatabaseGame = new Database();
            MessageBox.Show(ex.Message, @"Import database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            textReader?.Close();
            if (DatabaseGame != null && DatabaseGame.TeamList.Count > 0)
            {
                DatabaseGame.OrderAfterLoad();
                TeamsDBT1.DataSource = DatabaseGame.TeamList;
                TeamsDBT1.SelectedItem = DatabaseGame.TeamList[0];
                TeamsDBT2.BindingContext = new BindingContext();
                TeamsDBT2.DataSource = DatabaseGame.TeamList;
                TeamsDBT2.SelectedItem = DatabaseGame.TeamList[1];
                adsDBV.DataSource = null;
                adsDBV.DataSource = DatabaseGame.AdvList;
            }
                
        }
    }

    // exports DB to xml
    private void ExportToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        SaveFileDialog saveFileDialog1 = new();
        saveFileDialog1.Filter = @"xml files (*.xml)|*.xml";
        saveFileDialog1.InitialDirectory = $"{Environment.CurrentDirectory}\\DB";
        TextWriter textWriter = null;

        try
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            XmlSerializer serializer = new(typeof(Database));
            textWriter = new StreamWriter(saveFileDialog1.FileName);
            serializer.Serialize(textWriter, DatabaseGame);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Export database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            textWriter?.Close();
        }
    }

    // drops all DB stored in DB
    private void DropToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        DatabaseGame = new Database();
        TeamsDBT1.DataSource = null;
        _matchStats.TeamStats[0].Name = null;
        videoPath1.Text =null;
        team1NameBox.Text = null;
        logo1Path.Text = null;
        _formScoreBoard.SetTeamName(true, _matchStats.TeamStats[0].Name);
        logo1.Image = null;
        TeamsDBT2.DataSource =  null;
        _matchStats.TeamStats[1].Name = null;
        videoPath2.Text =null;
        team2NameBox.Text = null;
        logo2Path.Text = null;
        adsDBV.DataSource = null;
        _formScoreBoard.SetTeamName(false, _matchStats.TeamStats[1].Name);
        logo2.Image = null;
        _team1 = null;
        _team2 = null;
        InitBoards();
            
    }

    // shows form to load advertisements to DB
    private void LoadToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        var ads = new LoadAds(this);
        ads.Database.AdvList = DatabaseGame.AdvList;
        ads.ShowDialog();
        if (!ads.IsDisposed) return;
        if (ads.Database.AdvList == null) return;
        DatabaseGame.AdvList = ads.Database.AdvList;
        adsDBV.DataSource = null;
        adsDBV.DataSource = DatabaseGame.AdvList;
    }

    private void VideoPath1MouseDoubleClick(object parSender, MouseEventArgs parE)
    {
        videoPath1.SelectAll();
    }

    private void VideoPath2MouseDoubleClick(object parSender, MouseEventArgs parE)
    {
        videoPath2.SelectAll();
    }

    private void TimeToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        _gameTimes.Show();
    }

    private void PlusShotsT1Click(object parSender, EventArgs parE)
    {
        _matchStats.TeamStats[0].Shots++;
        _formScoreBoard.SetShots(true,_matchStats.TeamStats[0].Shots);
        shotsT1.Text = _matchStats.TeamStats[0].Shots.ToString();
    }

    private void PlusShotsT2Click(object parSender, EventArgs parE)
    {
        _matchStats.TeamStats[1].Shots++;
        _formScoreBoard.SetShots(false,_matchStats.TeamStats[1].Shots);
        shotsT2.Text = _matchStats.TeamStats[1].Shots.ToString();
    }

    private void PlusFaceOffsT1Click(object parSender, EventArgs parE)
    {
        if (_timer.Enabled || _breakRunning) return;
        _matchStats.TeamStats[0].FaceOffs++;
        _formScoreBoard.SetFaceOff(true,_matchStats.TeamStats[0].FaceOffs);
        faceoffsT1.Text = _matchStats.TeamStats[0].FaceOffs.ToString();
        StartTimer();
        DisplayTimeTimer(parSender,parE);
        _matchStats.CreateFaceOffEvent(1,_elapsedTime);
    }

    private void PlusFaceOffsT2Click(object parSender, EventArgs parE)
    {
        if (_timer.Enabled || _breakRunning) return;

        _matchStats.TeamStats[1].FaceOffs++;
        _formScoreBoard.SetFaceOff(false,_matchStats.TeamStats[1].FaceOffs);
        faceoffsT2.Text = _matchStats.TeamStats[1].FaceOffs.ToString();
        StartTimer();
        DisplayTimeTimer(parSender,parE);
        _matchStats.CreateFaceOffEvent(2,_elapsedTime);
    }

    private void MinusShotsT1Click(object parSender, EventArgs parE)
    {
        if (_matchStats.TeamStats[0].Shots <= 0) return;
        _matchStats.TeamStats[0].Shots --;
        _formScoreBoard.SetShots(true,_matchStats.TeamStats[0].Shots);
        shotsT1.Text = _matchStats.TeamStats[0].Shots.ToString();
    }

    private void MinusFaceOffsT1Click(object parSender, EventArgs parE)
    {
        if (_matchStats.TeamStats[0].FaceOffs <= 0) return;
        _matchStats.TeamStats[0].FaceOffs --;
        _formScoreBoard.SetFaceOff(true,_matchStats.TeamStats[0].FaceOffs);
        faceoffsT1.Text = _matchStats.TeamStats[0].FaceOffs.ToString();
    }

    private void MinusShotsT2Click(object parSender, EventArgs parE)
    {
        if (_matchStats.TeamStats[1].Shots <= 0) return;
        _matchStats.TeamStats[1].Shots --;
        _formScoreBoard.SetShots(false,_matchStats.TeamStats[1].Shots);
        shotsT2.Text = _matchStats.TeamStats[1].Shots.ToString();
    }

    private void MinusFaceOffsT2Click(object parSender, EventArgs parE)
    {
        if (_matchStats.TeamStats[1].FaceOffs <= 0) return;
        _matchStats.TeamStats[1].FaceOffs --;
        _formScoreBoard.SetFaceOff(false,_matchStats.TeamStats[1].FaceOffs);
        faceoffsT2.Text = _matchStats.TeamStats[1].FaceOffs.ToString();
    }

    private void SetPt1P1Click(object parSender, EventArgs parE)
    {
        SetPenalty(1);
    }

    private void SetPt1P2Click(object parSender, EventArgs parE)
    {
        SetPenalty(2);
    }

    private void SetT2P1Click(object parSender, EventArgs parE)
    {
        SetPenalty(3);
    }

    private void SetT2P2Click(object parSender, EventArgs parE)
    {
        SetPenalty(4);
    }

    // sets penalty for specific player from specific team
    // team is based on position from parameter
    // it shows SetPenaltyForm dialog and also after that creates event to minute by minute export
    private void SetPenalty(int parPosition)
    {
        StopTime();
        var players = new List<Player>();

        switch (parPosition)
        {
            case < 3 when _team1 != null:
                players = _team1.Players;
                break;
            case > 2 when _team2 != null:
                players = _team2.Players;
                break;
        }

        var form = new SetPenaltyForm(_gameTimes, players);
        form.ShowDialog();
        if (form.DialogResult != DialogResult.OK) return;
        switch (parPosition)
        {
            case 1:
                for (var i = 0; i < _penalty[0].Length; i++)
                {
                    _penalty[0][i] =  form.Penalty[i];
                }
                _matchStats.CreatePenaltyEvent(1,new Time {Minutes =form.Penalty[1], Seconds = form.Penalty[2]}, _elapsedTime);
                _activePenalty[0] = true;
                break;
            case 2:
                for (var i = 0; i < _penalty[0].Length; i++)
                {
                    _penalty[1][i] =  form.Penalty[i];
                }
                _matchStats.CreatePenaltyEvent(1,new Time {Minutes =form.Penalty[1], Seconds = form.Penalty[2]}, _elapsedTime);
                _activePenalty[1] = true;
                break;
            case 3:
                for (var i = 0; i < _penalty[0].Length; i++)
                {
                    _penalty[2][i] =  form.Penalty[i];
                }
                _matchStats.CreatePenaltyEvent(2,new Time {Minutes =form.Penalty[1], Seconds = form.Penalty[2]}, _elapsedTime);
                _activePenalty[2] = true;
                break;
            case 4:
                for (var i = 0; i < _penalty[0].Length; i++)
                {
                    _penalty[3][i] =  form.Penalty[i];
                }
                _matchStats.CreatePenaltyEvent(2,new Time {Minutes =form.Penalty[1], Seconds = form.Penalty[2]}, _elapsedTime);
                _activePenalty[3] = true;
                break;
        }
        InitBoards();
        _serialDevices.SirenStart(SirenType.Short);
    }

    private void ExitToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        Dispose();
    }

    // shows / hides statistic controls depending on which are active
    private void SelectStats(bool[] parStats)
    {
        if (parStats.Length == 0) throw new ArgumentException(@"Value cannot be an empty collection.", nameof(parStats));
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

    // shows dialog to select active statistics
    private void SelectStatisticsToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        if (_formScoreBoard.IsActive)
        {
            _statSettings.ShowDialog();
            if (_statSettings.DialogResult != DialogResult.OK) return;
            SelectStats(_statSettings.ActiveStatistics);
            _formScoreBoard.SelectStats(_statSettings.ActiveStatistics);
        }
        else
        {
            MessageBox.Show(@"You have to create scoreboard at first!" , @"Add team Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // shows settings of minute by minute export
    private void ExportSettingsToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        if (_matchStats == null) return;
        _exportSettings.ShowDialog();
        if (_exportSettings.DialogResult != DialogResult.OK) return;
        _matchStats.ExportEvents = _exportSettings.Export;
        _matchStats.ExpoPath = _exportSettings.Path;
    }
    // sets special timer settings
    private void ShootoutBtnClick(object parSender, EventArgs parE)
    {
        if (_formScoreBoard.IsActive)
        {
            if (_timer.Enabled) return;
            _matchTime = new Time {Minutes = 0, Seconds = 0};
            period.Text = @"SH";
            _formScoreBoard.SetPeriod("SH");
            _formScoreBoard.SetTime(_matchTime);
            UpdateTime(_matchTime);
            _specialTime = true;
        }
        else
        {
            MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void OverTBreakClick(object parSender, EventArgs parE)
    {
        if (_formScoreBoard.IsActive)
        {
            if (_timer.Enabled) return;
            _matchTime = _gameTimes.BreakOvertLength;
            _breakRunning = true;
            period.Text = @"OB";
            _formScoreBoard.SetPeriod("OB");
            _formScoreBoard.SetTime(_matchTime);
            UpdateTime(_matchTime);
            _specialTime = true;
        }
        else
        {
            MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void PreMatchCountClick(object parSender, EventArgs parE)
    {
        if (_formScoreBoard.IsActive)
        {
            if (_timer.Enabled) return;
            _matchTime = _gameTimes.PreMatchTime;
            period.Text = @" ";
            _formScoreBoard.SetPeriod(" ");
            _formScoreBoard.SetTime(_matchTime);
            _specialTime = true;
            UpdateTime(_matchTime);
        }
        else
        {
            MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void OverT1Click(object parSender, EventArgs parE)
    {
        if (_formScoreBoard.IsActive)
        {
            if (_timer.Enabled) return;
            _matchTime = _gameTimes.PeriodOvertLength;
            _breakRunning = true;
            period.Text = @"O1";
            _formScoreBoard.SetPeriod("O1");
            _formScoreBoard.SetTime(_matchTime);
            UpdateTime(_matchTime);
            _specialTime = true;
        }
        else
        {
            MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void OverT2Click(object parSender, EventArgs parE)
    {
        if (_formScoreBoard.IsActive)
        {
            if (_timer.Enabled) return;
            _matchTime = _gameTimes.PeriodOvertLength;
            _breakRunning = true;
            period.Text = @"O2";
            _formScoreBoard.SetPeriod("O2");
            _formScoreBoard.SetTime(_matchTime);
            UpdateTime(_matchTime);
            _specialTime = true;
        }
        else
        {
            MessageBox.Show(@"You have to create scoreboard at first!", @"Add team Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
    //

    // shows control form to set appearance of scoreboard
    private void AppearanceToolStripMenuItemClick(object parSender, EventArgs parE)
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

    // shows serial port communication settings
    private void AuxiliaryDevicesToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        if (_serialDevices == null || _serialDevices.IsDisposed) _serialDevices = new SerialPortSettings();
        _serialDevices.Show();

    }

    // shows manual event form
    private void CustomEventToolStripMenuItemClick(object parSender, EventArgs parE)
    {
        var help = new ManualEvent();
        help.ShowDialog();
        if (help.DialogResult == DialogResult.OK)
        {
            _matchStats.CreateManualEvent(help.Description,help.EventName);
        }
    }

    // deletes settings for logos
    private void CancelLogo1Click(object parSender, EventArgs parE)
    {
        logo1.Image = null;
        logo1Path.Text = string.Empty;
    }

    private void CancelLogo2Click(object parSender, EventArgs parE)
    {
        logo2.Image = null;
        logo2Path.Text = string.Empty;
    }
    //

    // resets elapsed time, is good to use if user made mistake and wants to reset elapsed time without re-opening app
    // elapsed time is used for exporting data minute by minute when time is always a name of text file
    private void ResetElapsedBtnClick(object parSender, EventArgs parE)
    {
        _elapsedTime = new Time {Minutes = 0, Seconds = 0};
    }
}