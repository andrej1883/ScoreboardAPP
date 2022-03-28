using Scoreboard.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Scoreboard.Forms.MainGameForms;

// scoreboard is form used for displaying score and all statistics about match on seconds display 
// scoreboard is responsible mostly for displaying data on it, not for app logic
// it has setters and getters for colors and fonts displayed
// scoreboard is singleton
public partial class ScoreboardForm : Form
{
    private bool _isLocked = true;
    private Point _mouseClick;
    private static ScoreboardForm _instance;

    public bool IsActive { get; set; }

    public Color ScoSColor
    {
        get => scoreT1Lbl.ForeColor;
        set
        {
            scoreT1Lbl.ForeColor = value;
            scoreParseLblb.ForeColor = value;
            scoreT2Lbl.ForeColor = value;
        }
    }

    public Color ScoLColor
    {
        get => t1Lbl.ForeColor;
        set
        {
            t1Lbl.ForeColor = value;
            t2Lbl.ForeColor = value;
        }

    }

    public Color TimeCColor
    {
        get => timeMinutesLbl.ForeColor;
        set
        {
            timeMinutesLbl.ForeColor = value;
            timeSecondsLbl.ForeColor = value;
            timeParseLbl.ForeColor = value;
        }
    }

    public Color TimeLColor
    {
        get => timeLbl.ForeColor;
        set => timeLbl.ForeColor = value;
    }

    public Color PeriodColor
    {
        get => actualPeriodLbl.ForeColor;
        set => actualPeriodLbl.ForeColor = value;
    }

    public Color PenaltyDColor
    {
        get => playerNumber1T1lbl.ForeColor;
        set
        {
            playerNumber1T1lbl.ForeColor = value;
            playerNumber1T2lbl.ForeColor = value;
            playerNumber2T1lbl.ForeColor = value;
            playerNumber2T2lbl.ForeColor = value;
            minutesT1P1Lbl.ForeColor = value;
            minutesT1P2Lbl.ForeColor = value;
            minutesT2P1Lbl.ForeColor = value;
            minutesT2P2Lbl.ForeColor = value;
            timeT1P1ParseLbl.ForeColor = value;
            timeT1P2ParseLbl.ForeColor = value;
            timeT2P1ParseLbl.ForeColor = value;
            timeT2P2ParseLbl.ForeColor = value;
            secondsT1P1Lbl.ForeColor = value;
            secondsT1P2Lbl.ForeColor = value;
            secondsT2P1Lbl.ForeColor = value;
            secondsT2P2Lbl.ForeColor = value;
        }
    }

    public Color PenaltyLColor
    {
        get => penaltyT1Lbl.ForeColor;
        set
        {
            penaltyT1Lbl.ForeColor = value;
            penaltyT2Lbl.ForeColor = value;
            penaltyT1PlayerLbl.ForeColor = value;
            penaltyT2PlayerLbl.ForeColor = value;
            penaltyT1TimeLbl.ForeColor = value;
            penaltyT2TimeLbl.ForeColor = value;
        }
    }

    public Color PeriodLColor
    {
        get => periodLbl.ForeColor;
        set => periodLbl.ForeColor = value;
    }

    public Color TimeoutLColor
    {
        get => timeoutL1.ForeColor;
        set
        {
            timeoutL1.ForeColor = value;
            timeoutL2.ForeColor = value;
        }
    }

    public Color TimeoutTColor
    {
        get => timeout1Min.ForeColor;
        set
        {
            timeout1Min.ForeColor = value;
            timeout1Sec.ForeColor = value;
            timeout2Min.ForeColor = value;
            timeout2Sec.ForeColor = value;
        }
    }

    public Color FaceOffLColor
    {
        get => faceOffsT1Lbl.ForeColor;
        set
        {
            faceOffsT1Lbl.ForeColor = value;
            faceOffsT2Lbl.ForeColor = value;
        }
    }

    public Color FaceOffFaceColor
    {
        get => faceOffsT1.ForeColor;
        set
        {
            faceOffsT1.ForeColor = value;
            faceOffsT2.ForeColor = value;
        }
    }

    public Color ShotsLColor
    {
        get => shotsT1Lbl.ForeColor;
        set
        {
            shotsT1Lbl.ForeColor = value;
            shotsT2Lbl.ForeColor = value;
        }
    }

    public Color ShotsSColor
    {
        get => shotsT1.ForeColor;
        set
        {
            shotsT1.ForeColor = value;
            shotsT2.ForeColor = value;
        }
    }

    public Color BackGrColor
    {
        get => BackColor;
        set
        {
            if (value != Color.Transparent) BackColor = value;
            foreach (var lbl in _instance.Controls.OfType<Label>())
            {
                lbl.BackColor = value;
            }
        }
    }

    public Font ScoSFont
    {
        get => scoreT1Lbl.Font;
        set
        {
            scoreT1Lbl.Font = value;
            scoreT2Lbl.Font = value;
            scoreParseLblb.Font = value;
        }
    }

    public Font ScoLFont
    {
        get => t1Lbl.Font;
        set
        {
            t1Lbl.Font = value;
            t2Lbl.Font = value;
        }
    }

    public Font TimeCFont
    {
        get => timeMinutesLbl.Font;
        set
        {
            timeMinutesLbl.Font = value;
            timeParseLbl.Font = value;
            timeSecondsLbl.Font = value;
        }
    }

    public Font TimeLFont
    {
        get => timeLbl.Font;
        set => timeLbl.Font = value;
    }

    public Font PeriodPFont
    {
        get => actualPeriodLbl.Font;
        set => actualPeriodLbl.Font = value;
    }

    public Font PeriodLFont
    {
        get => periodLbl.Font;
        set => periodLbl.Font = value;
    }

    public Font PenaltyDFont
    {
        get => playerNumber1T1lbl.Font;
        set
        {
            playerNumber1T1lbl.Font = value;
            playerNumber2T1lbl.Font = value;
            minutesT1P1Lbl.Font = value;
            timeT1P1ParseLbl.Font = value;
            secondsT1P1Lbl.Font = value;
            minutesT1P2Lbl.Font = value;
            timeT1P2ParseLbl.Font = value;
            secondsT1P2Lbl.Font = value;
            playerNumber1T2lbl.Font = value;
            playerNumber2T2lbl.Font = value;
            minutesT2P1Lbl.Font = value;
            timeT2P1ParseLbl.Font = value;
            secondsT2P1Lbl.Font = value;
            minutesT2P2Lbl.Font = value;
            timeT2P2ParseLbl.Font = value;
            secondsT2P2Lbl.Font = value;

        }
    }

    public Font PenaltyLFont
    {
        get => penaltyT1Lbl.Font;
        set
        {
            penaltyT1Lbl.Font = value;
            penaltyT2Lbl.Font = value;
            penaltyT1PlayerLbl.Font = value;
            penaltyT1TimeLbl.Font = value;
            penaltyT2PlayerLbl.Font = value;
            penaltyT2TimeLbl.Font = value;
        }
    }

    public Font TimeoutLFont
    {
        get => timeoutL1.Font;
        set
        {
            timeoutL1.Font = value;
            timeoutL2.Font = value;
        }
    }

    public Font TimeoutTFont
    {
        get => timeout1Min.Font;
        set
        {
            timeout1Min.Font = value;
            timeout2Min.Font = value;
            timeout1Sec.Font = value;
            timeout2Sec.Font = value;
            timeout1Parse.Font = value;
            timeout2Parse.Font = value;

        }
    }

    public Font FaceOffLFont
    {
        get => faceOffsT1Lbl.Font;
        set
        {
            faceOffsT1Lbl.Font = value;
            faceOffsT2Lbl.Font = value;
        }
    }

    public Font FaceOffFaceFont
    {
        get => faceOffsT1.Font;
        set
        {
            faceOffsT1.Font = value;
            faceOffsT2.Font = value;
        }
    }

    public Font ShotsLFont
    {
        get => shotsT1Lbl.Font;
        set
        {
            shotsT1Lbl.Font = value;
            shotsT2Lbl.Font = value;
        }
    }

    public Font ShotsSFont
    {
        get => shotsT1.Font;
        set
        {
            shotsT1.Font = value;
            shotsT2.Font = value;
        }
    }

    public Size LogoSize
    {
        get => team1Logo.Size;
        set
        {
            team1Logo.Size = value;
            team2Logo.Size = value;
        }
    }

    public bool IsLocked
    {
        get => _isLocked;
        set
        {
            foreach (Control ctr in Controls)
            {
                ctr.BackColor = value ? BackGrColor : Color.Red;
            }
            _isLocked = value;
        }
    }

    public int GridSize { get; set; } = 50;

    // creates instance of scoreboard
    internal static ScoreboardForm GetInstance()
    {
        if (_instance != null) return _instance;
        _instance = new ScoreboardForm();
        _instance.FormBorderStyle = FormBorderStyle.None;
        _instance.MinimizeBox = false;
        _instance.MaximizeBox = false;
        _instance.ControlBox = false;
        var bounds = Screen.AllScreens[1].Bounds;
        _instance.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
        _instance.StartPosition = FormStartPosition.Manual;
        _instance.TopMost = true;
        return _instance;
    }

    public ScoreboardForm()
    {
        InitializeComponent();
    }

    public void ResetInstance()
    {
        _instance = null;
    }


    public void SetTimeout(int parTeam1, Time parTime)
    {
        switch (parTeam1)
        {
            case 1:
                timeout1Min.Text = CheckZero(parTime.Minutes);
                timeout1Sec.Text = CheckZero(parTime.Seconds);
                break;
            case 2:
                timeout2Min.Text = CheckZero(parTime.Minutes);
                timeout2Sec.Text = CheckZero(parTime.Seconds);
                break;
        }
    }

    public void SetFaceOff(bool parTeam1, int parValue)
    {
        if (parTeam1)
        {
            faceOffsT1.Text = parValue.ToString();
        }
        else
        {
            faceOffsT2.Text = parValue.ToString();
        }
    }

    public void SetShots(bool parTeam1, int parValue)
    {
        if (parTeam1)
        {
            shotsT1.Text = parValue.ToString();
        }
        else
        {
            shotsT2.Text = parValue.ToString();
        }
    }

    public void SetGoal(bool parTeam1, int parGoals)
    {
        if (parTeam1)
        {
            scoreT1Lbl.Text = parGoals.ToString();
        }
        else
        {
            scoreT2Lbl.Text = parGoals.ToString();
        }

    }

    public void HidePenalty(int parPosition)
    {

        switch (parPosition)
        {
            case 1:
                playerNumber1T1lbl.Visible = false;
                minutesT1P1Lbl.Visible = false;
                timeT1P1ParseLbl.Visible = false;
                secondsT1P1Lbl.Visible = false;
                break;
            case 2:
                playerNumber2T1lbl.Visible = false;
                minutesT1P2Lbl.Visible = false;
                timeT1P2ParseLbl.Visible = false;
                secondsT1P2Lbl.Visible = false;
                break;
            case 3:
                playerNumber1T2lbl.Visible = false;
                minutesT2P1Lbl.Visible = false;
                timeT2P1ParseLbl.Visible = false;
                secondsT2P1Lbl.Visible = false;
                break;
            case 4:
                playerNumber2T2lbl.Visible = false;
                minutesT2P2Lbl.Visible = false;
                timeT2P2ParseLbl.Visible = false;
                secondsT2P2Lbl.Visible = false;
                break;
            default:
                throw new ArgumentException("Index is out of range");
        }
    }

    public void ShowPenalty(int parPosition)
    {
        switch (parPosition)
        {
            case 1:
                playerNumber1T1lbl.Visible = true;
                minutesT1P1Lbl.Visible = true;
                timeT1P1ParseLbl.Visible = true;
                secondsT1P1Lbl.Visible = true;
                break;
            case 2:
                playerNumber2T1lbl.Visible = true;
                minutesT1P2Lbl.Visible = true;
                timeT1P2ParseLbl.Visible = true;
                secondsT1P2Lbl.Visible = true;
                break;
            case 3:
                playerNumber1T2lbl.Visible = true;
                minutesT2P1Lbl.Visible = true;
                timeT2P1ParseLbl.Visible = true;
                secondsT2P1Lbl.Visible = true;
                break;
            case 4:
                playerNumber2T2lbl.Visible = true;
                minutesT2P2Lbl.Visible = true;
                timeT2P2ParseLbl.Visible = true;
                secondsT2P2Lbl.Visible = true;
                break;
            default:
                throw new ArgumentException("Index is out of range");
        }
    }

    public void SetPenalty(int parPosition, int parNumber, int parMinutes, int parSeconds)
    {
        var sMinutes = CheckZero(parMinutes);
        var sSeconds = CheckZero(parSeconds);

        switch (parPosition)
        {
            case 1:
                playerNumber1T1lbl.Text = parNumber.ToString();
                minutesT1P1Lbl.Text = sMinutes;
                secondsT1P1Lbl.Text = sSeconds;
                break;
            case 2:
                playerNumber2T1lbl.Text = parNumber.ToString();
                minutesT1P2Lbl.Text = sMinutes;
                secondsT1P2Lbl.Text = sSeconds;
                break;
            case 3:
                playerNumber1T2lbl.Text = parNumber.ToString();
                minutesT2P1Lbl.Text = sMinutes;
                secondsT2P1Lbl.Text = sSeconds;
                break;
            case 4:
                playerNumber2T2lbl.Text = parNumber.ToString();
                minutesT2P2Lbl.Text = sMinutes;
                secondsT2P2Lbl.Text = sSeconds;
                break;
            default:
                throw new ArgumentException("Index is out of range");
        }
    }

    public void SetPeriod(string parPeriod)
    {
        actualPeriodLbl.Text = parPeriod;
    }

    public void SetTeamName(bool parTeam1, string parName)
    {
        if (parTeam1)
            t1Lbl.Text = parName;
        else
            t2Lbl.Text = parName;
    }

    public void SetLogo(bool parTeam1, Image parLogo)
    {
        if (parTeam1)
            team1Logo.Image = parLogo;
        else
            team2Logo.Image = parLogo;
    }

    public void HideLogo(bool parTeam1)
    {
        if (parTeam1)
            team1Logo.Hide();
        else
            team2Logo.Hide();
    }

    public void ShowLogo(bool parTeam1)
    {
        if (parTeam1)
            team1Logo.Show();
        else
            team2Logo.Show();
    }

    public void SetTime(Time parTime)
    {
        timeMinutesLbl.Text = CheckZero(parTime.Minutes);
        timeSecondsLbl.Text = CheckZero(parTime.Seconds);
    }

    public override string ToString()
    {
        return
            $"{BackGrColor}|{PenaltyDColor.ToArgb()}|{PenaltyLColor.ToArgb()}|{PeriodColor.ToArgb()}|{PeriodLColor.ToArgb()}|{TimeLColor.ToArgb()}|{ScoLColor.ToArgb()}|{ScoSColor.ToArgb()}|{TimeCColor.ToArgb()}|{PenaltyDFont.Size}|{PenaltyLFont.Size}|{PeriodLFont.Size}|{PeriodPFont.Size}|{TimeLFont.Size}|{ScoLFont.Size}|{ScoSFont.Size}|{TimeCFont.Size}|{Width}|{Height}";
    }

    private static string CheckZero(int parNumber)
    {
        return parNumber < 10 ? $"0{parNumber}" : parNumber.ToString();
    }

    // shows active stats
    public void SelectStats(bool[] parOptions)
    {
        if (!parOptions[0])
        {
            timeoutL1.Hide();
            timeoutL2.Hide();
            timeout1Min.Hide();
            timeout1Parse.Hide();
            timeout2Parse.Hide();
            timeout1Sec.Hide();
            timeout2Min.Hide();
            timeout2Sec.Hide();
        }
        else
        {
            timeoutL1.Show();
            timeoutL2.Show();
            timeout1Min.Show();
            timeout1Parse.Show();
            timeout2Parse.Show();
            timeout1Sec.Show();
            timeout2Min.Show();
            timeout2Sec.Show();
        }

        if (!parOptions[1])
        {
            faceOffsT1Lbl.Hide();
            faceOffsT1.Hide();
            faceOffsT2Lbl.Hide();
            faceOffsT2.Hide();
        }
        else
        {
            faceOffsT1Lbl.Show();
            faceOffsT1.Show();
            faceOffsT2Lbl.Show();
            faceOffsT2.Show();
        }

        if (!parOptions[2])
        {
            shotsT1Lbl.Hide();
            shotsT1.Hide();
            shotsT2Lbl.Hide();
            shotsT2.Hide();
        }
        else
        {
            shotsT1Lbl.Show();
            shotsT1.Show();
            shotsT2Lbl.Show();
            shotsT2.Show();
        }
    }

    // moves scoreboard elements when scoreboard is resized
    public void MoveComponents()
    {
        foreach (Control ctr in Controls)
        {
            if (ctr.Location.X + ctr.Width > Width)
            {
                ctr.Location = new Point(Width - ctr.Width, ctr.Location.Y);
            }
            if (ctr.Location.Y + ctr.Height > Height)
            {
                ctr.Location = new Point(ctr.Location.X, Height - ctr.Height);
            }
        }
    }

    // functions to move specific elements on scoreboard by mouse
    // unlock in control form must be active

    private void SaveMouseLocation(MouseEventArgs parE)
    {
        if (parE.Button == MouseButtons.Left && !_isLocked)
        {
            _mouseClick = parE.Location;
        }
    }

    private void ReplaceObject(MouseEventArgs parE, Control parToBeMoved)
    {
        if (parE.Button != MouseButtons.Left || _isLocked) return;
        var y = parE.Y - _mouseClick.X;
        y -= y % GridSize;
        parToBeMoved.Top += y;
        var x = parE.X - _mouseClick.X;
        x -= x % GridSize;
        parToBeMoved.Left += x;
    }

    private void Team1LogoMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Team1LogoMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, team1Logo);
    }

    private void ScoreT1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ScoreT1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, scoreT1Lbl);
    }

    private void T1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void T1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, t1Lbl);
    }

    private void ScoreParseLblbMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ScoreParseLblbMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, scoreParseLblb);
    }

    private void ScoreT2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void T2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void T2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, t2Lbl);
    }

    private void Team2LogoMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Team2LogoMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, team2Logo);
    }

    private void PeriodLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ActualPeriodLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, actualPeriodLbl);
    }

    private void TimeLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeLbl);
    }

    private void TimeMinutesLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeMinutesLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeMinutesLbl);
    }

    private void TimeParseLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeParseLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeParseLbl);
    }

    private void TimeSecondsLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeSecondsLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeSecondsLbl);
    }

    private void TimeoutL1MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeoutL1MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeoutL1);
    }

    private void Timeout1MinMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Timeout1MinMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeout1Min);
    }

    private void Label6MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Label6MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeout1Parse);
    }

    private void Timeout1SecMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Timeout1SecMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeout1Sec);
    }

    private void TimeoutL2MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeoutL2MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeoutL2);
    }

    private void Timeout2MinMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Timeout2MinMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeout2Min);
    }

    private void Label3MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Label3MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeout2Parse);
    }

    private void Timeout2SecMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void Timeout2SecMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeout2Sec);
    }

    private void PenaltyT1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PenaltyT1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, penaltyT1Lbl);
    }

    private void PenaltyT1PlayerLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PenaltyT1PlayerLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, penaltyT1PlayerLbl);
    }

    private void PenaltyT1TimeLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PenaltyT1TimeLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, penaltyT1TimeLbl);
    }

    private void PlayerNumber1T1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PlayerNumber1T1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, playerNumber1T1lbl);
    }

    private void PlayerNumber2T1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PlayerNumber2T1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, playerNumber2T1lbl);
    }

    private void MinutesT1P1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void MinutesT1P1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, minutesT1P1Lbl);
    }

    private void TimeT1P1ParseLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeT1P1ParseLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeT1P1ParseLbl);
    }

    private void SecondsT1P1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void SecondsT1P1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, secondsT1P1Lbl);
    }

    private void MinutesT1P2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void MinutesT1P2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, minutesT1P2Lbl);
    }

    private void TimeT1P2ParseLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeT1P2ParseLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeT1P2ParseLbl);
    }

    private void SecondsT1P2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void SecondsT1P2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, secondsT1P2Lbl);
    }

    private void PlayerNumber1T2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PlayerNumber1T2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, playerNumber1T2lbl);
    }

    private void PlayerNumber2T2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PlayerNumber2T2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, playerNumber2T2lbl);
    }

    private void MinutesT2P1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void MinutesT2P1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, minutesT2P1Lbl);
    }

    private void TimeT2P1ParseLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeT2P1ParseLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeT2P1ParseLbl);
    }

    private void SecondsT2P1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void SecondsT2P1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, secondsT2P1Lbl);
    }

    private void MinutesT2P2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void MinutesT2P2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, minutesT2P2Lbl);
    }

    private void TimeT2P2ParseLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void TimeT2P2ParseLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, timeT2P2ParseLbl);
    }

    private void SecondsT2P2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void SecondsT2P2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, secondsT2P2Lbl);
    }

    private void PenaltyT2PlayerLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PenaltyT2PlayerLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, penaltyT2PlayerLbl);
    }

    private void PenaltyT2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PenaltyT2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, penaltyT2Lbl);
    }

    private void PenaltyT2TimeLblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void PenaltyT2TimeLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, penaltyT2TimeLbl);
    }

    private void PeriodLblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, periodLbl);
    }

    private void ScoreT2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, scoreT2Lbl);
    }

    private void FaceOffsT1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void FaceOffsT1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, faceOffsT1Lbl);
    }

    private void FaceOffsT1MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void FaceOffsT1MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, faceOffsT1);
    }

    private void FaceOffsT2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void FaceOffsT2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, faceOffsT2Lbl);
    }

    private void FaceOffsT2MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void FaceOffsT2MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, faceOffsT2);
    }

    private void ShotsT1LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ShotsT1LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, shotsT1Lbl);
    }

    private void ShotsT1MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ShotsT1MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, shotsT1);
    }

    private void ShotsT2LblMouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ShotsT2LblMouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, shotsT2Lbl);
    }

    private void ShotsT2MouseDown(object parSender, MouseEventArgs parE)
    {
        SaveMouseLocation(parE);
    }

    private void ShotsT2MouseMove(object parSender, MouseEventArgs parE)
    {
        ReplaceObject(parE, shotsT2);
    }
}